using Android.App;
using Android.Content;
using System.Linq;
using Android.Widget;
using CiuchApp.Domain;
using System;
using CiuchApp.Mobile.Extensions;
using System.ComponentModel;
using System.Collections.Generic;
using CiuchApp.Settings;
using CiuchApp.ApiClient;
using CiuchApp.Mobile.Helpers;
using System.Linq.Expressions;

namespace CiuchApp.Mobile.Activities
{
    public class CiuchAppBaseActivity : Activity
    {
        public ICiuchAppSettings _settings;
        public IApiClient _apiClient;
        public IEnvironmentHelper _environmentHelper;

        private CacheContext _cacheContext;
        protected CacheContext CacheContext {
            get
            {
                if(_cacheContext == null)
                {
                    EnsureCahceContext();
                }
                return _cacheContext;
            }
        }
        /*..................................................................................................*/
        private readonly string currentBusinessTripJsonKey = nameof(currentBusinessTripJsonKey);
        private BusinessTrip _currentbusinessTrip;
        protected BusinessTrip CurrentBusinessTrip
        {
            get
            {
                if(_currentbusinessTrip == null && int.TryParse(Intent.GetStringExtra(currentBusinessTripJsonKey), out int id))
                {
                    _currentbusinessTrip = CacheContext.BusinessTrips.FirstOrDefault(x => x.Id == id);
                }
                return _currentbusinessTrip;
            }
        }
        /*..................................................................................................*/
        private readonly string currentPieceJsonKey = nameof(currentPieceJsonKey);
        private Piece _currentPiece;
        protected Piece CurrentPiece
        {
            get
            {
                if (_currentPiece == null && int.TryParse(Intent.GetStringExtra(currentPieceJsonKey), out int id))
                {
                    _currentPiece = CurrentBusinessTrip.Pieces.FirstOrDefault(x => x.Id == id);
                }
                return _currentPiece;
            }
        }
        protected void SetCurrentPiece(Piece newPiece)
        {
            _currentPiece = newPiece;
        }
        /*..................................................................................................*/
        private readonly string currentSizeAmountJsonKey = nameof(currentSizeAmountJsonKey);
        private SizeAmountPair _currentSizeAmount;
        protected SizeAmountPair CurrentSizeAmount
        {
            get
            {
                if (_currentSizeAmount == null && int.TryParse(Intent.GetStringExtra(currentSizeAmountJsonKey), out int id))
                {
                    _currentSizeAmount = CurrentPiece.SizeAmountPairs.FirstOrDefault(x => x.Id == id);
                }
                return _currentSizeAmount;
            }
        }
        protected void SetCurrentSizeAmount(SizeAmountPair newSizeAmount)
        {
            _currentSizeAmount = newSizeAmount;
        }
        /*..................................................................................................*/

        public CiuchAppBaseActivity()
        {
            _settings = (ICiuchAppSettings)App.Container.GetService(typeof(ICiuchAppSettings));
            _apiClient = (IApiClient)App.Container.GetService(typeof(IApiClient));
            _environmentHelper = (IEnvironmentHelper)App.Container.GetService(typeof(IEnvironmentHelper));
        }

        /// <summary>
        /// Try get cacheContext from previous action.
        /// If null then call to api
        /// </summary>
        protected void EnsureCahceContext()
        {
            _cacheContext = CacheContext.Deserialize(Intent.GetStringExtra(CacheContext.JsonKey));
            if (_cacheContext == null)
                _cacheContext = _apiClient.GetCache();
        }

        public void Next<T>(int? currentBusinessTrip=null, int? currentPiece = null, int? currentSizeAmount = null) where T : Activity
        {
            var nextActivity = new Intent(this, typeof(T));

            nextActivity.PutExtra(CacheContext.JsonKey, CacheContext.Serialize());

            if (currentBusinessTrip != null)
                nextActivity.PutExtra(currentBusinessTripJsonKey, currentBusinessTrip.ToString());
            if (currentPiece != null)
                nextActivity.PutExtra(currentPieceJsonKey, currentPiece.ToString());
            if (currentSizeAmount != null)
                nextActivity.PutExtra(currentPieceJsonKey, currentPiece.ToString());

            StartActivity(nextActivity);
        }

        protected void DatePickerFor(int datePickerId, object model, string dateFieldName)
        {
            DatePickerFor(datePickerId, model, dateFieldName, DateTime.Now);
        }

        protected void DatePickerFor(int datePickerId, object model, string dateFieldName, DateTime defaultValue)
        {
            var _datePicker = FindViewById<TextView>(datePickerId);

            var dateTimeValue = GetValue<DateTime>(model, dateFieldName);
            if (dateTimeValue == default(DateTime))
            {
                dateTimeValue = defaultValue;
            }

            _datePicker.Text = dateTimeValue.ToString("dd-MM-yyyy");
            SetValue(model, dateFieldName, dateTimeValue);

            _datePicker.Click += (s, e) =>
            {
                DatePickerFragment.NewInstance(delegate (DateTime date)
                {
                    _datePicker.Text = date.ToString("dd-MM-yyyy");
                    SetValue(model, dateFieldName, date);
                }).Show(FragmentManager, DatePickerFragment.TAG);
            };
        }

        protected void EditTextFor(int resourceId, object model, string fieldName, object defaultValue = null)
        {
            var _editText = FindViewById<EditText>(resourceId);

            //Text field is always a string
            var value = GetValue<string>(model, fieldName);
            if (value != default(string))
            {
                SetValue(model, fieldName, value);
                _editText.Text = value;
            }
            else if (defaultValue != null)
            {
                SetValue(model, fieldName, defaultValue);
                _editText.Text = value;
            }

            _editText.TextChanged += (s, e) =>
            {
                SetValue(model, fieldName, _editText.Text);
            };
        }

        protected Spinner SpinnerFor<T>(int spinnerId, object model, IList<T> values) where T : DropDownValueBase
        {
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, values.Select(x => x.Name).ToList());
            var spinner = FindViewById<Spinner>(spinnerId);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            spinner.SetSelection(GetValue<T>(model) - 1);
            spinner.ItemSelected += (s, e) => { SetValue<T>(model, values.ElementAt(e.Position).Id); }; //eventOnItemChanged(model);

            return spinner;
        }

        protected static int GetValue<T>(object model)
        {
            var prop = model.GetType().GetProperties().Where(x => x.PropertyType == typeof(T)).FirstOrDefault();
            if (prop != null)
            {
                var propName = prop.Name + "Id";
                return int.Parse(model.GetType().GetProperty(propName).GetValue(model, null).ToString());
            }
            throw new NullReferenceException();
        }

        protected static T GetValue<T>(object model, string fieldName)
        {
            var prop = model.GetType().GetProperties().Where(x => x.Name == fieldName).FirstOrDefault();
            if (prop == null)
                throw new NullReferenceException();

            var propValue = model.GetType().GetProperty(prop.Name).GetValue(model, null);
            if (propValue == null)
                return default(T);

            var converter = TypeDescriptor.GetConverter(typeof(T));
            if (converter == null)
                return default(T);

            return (T)converter.ConvertFromString(propValue.ToString());
        }

        protected static void SetValue<T>(object model, object value)
        {
            var prop = model.GetType().GetProperties().Where(x => x.PropertyType == typeof(T)).FirstOrDefault();
            if (prop == null)
            {
                throw new NullReferenceException();
            }

            var propName = prop.Name + "Id";
            model.GetType().GetProperty(propName).SetValue(model, value);
        }

        protected static void SetValue(object model, string fieldName, object value)
        {
            var prop = model.GetType().GetProperties().Where(x => x.Name == fieldName).FirstOrDefault();
            if (prop == null)
            {
                throw new NullReferenceException();
            }

            if (value == null || (value is string && string.IsNullOrEmpty((string)value)))
            {
                Type t = prop.PropertyType;
                object defaultValue = t.IsValueType ? Activator.CreateInstance(t) : null;
                value = defaultValue;
            }

            prop.SetValue(model, Convert.ChangeType(value, prop.PropertyType), null);
        }

        public T Deserialize<T>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        protected void ShowPopUp(string title, string message, Action funcOnClick)
        {
            var builder = new AlertDialog.Builder(this);
            builder.SetTitle(title);
            builder.SetMessage(message);
            builder.SetNeutralButton("OK", delegate
            {
                funcOnClick();
                builder.Dispose();
            });
            builder.Show();
        }
    }
}