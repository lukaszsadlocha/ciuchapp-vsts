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
using Android.Views;
using Android.Media;

namespace CiuchApp.Mobile.Activities
{
    public class CiuchAppBaseActivity : Activity
    {
        public ICiuchAppSettings _settings;
        public IApiClient _apiClient;
        public IEnvironmentHelper _environmentHelper;
        public IBitmapHelper _bitmapHelper;

        protected CacheContext _cacheContext;
        protected CacheContext CacheContext
        {
            get
            {
                if (_cacheContext == null)
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
                if (_currentbusinessTrip == null && int.TryParse(Intent.GetStringExtra(currentBusinessTripJsonKey), out int id))
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
            //Done this way to simplify derived classes constructors
            _settings = (ICiuchAppSettings)App.Container.GetService(typeof(ICiuchAppSettings));
            _apiClient = (IApiClient)App.Container.GetService(typeof(IApiClient));
            _environmentHelper = (IEnvironmentHelper)App.Container.GetService(typeof(IEnvironmentHelper));
            _bitmapHelper = (IBitmapHelper)App.Container.GetService(typeof(IBitmapHelper));
        }

        /// <summary>
        /// Try get cacheContext from previous action.
        /// If null then call to api
        /// </summary>
        protected async void EnsureCahceContext()
        {
            _cacheContext = CacheContext.Deserialize(Intent.GetStringExtra(CacheContext.JsonKey));
            if (_cacheContext == null)
                _cacheContext = await _apiClient.GetCacheAsync();
        }

        public void Next<T>(int? currentBusinessTrip = null, int? currentPiece = null, int? currentSizeAmount = null) where T : Activity
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

            //Bug 1 - in Polish Culture there is comma as double seperator
            //Double accepts dot as a seperator
            if (prop.PropertyType == typeof(double))
            {
                if (double.TryParse(value.ToString().Replace(",", "."), out var doubleValue))
                {
                    prop.SetValue(model, doubleValue, null);
                }
                return;
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

        #region TOOLBAR Properites & Methods
        private bool ShowNewMenuItem { get; set; }
        private bool ShowSaveMenuItem { get; set; }
        private bool ShowEditMenuItem { get; set; }
        private bool ShowSyncImagesMenuItem { get; set; }

        protected void SetToolbar(string toolbarTitle, bool showNewMenuItem = false, bool showEditMenuItem = false, bool showSaveMenuItem = false, bool showSyncImagesMenuItem = true)
        {
            ShowNewMenuItem = showNewMenuItem;
            ShowEditMenuItem = showEditMenuItem;
            ShowSaveMenuItem = showSaveMenuItem;
            ShowSyncImagesMenuItem = showSyncImagesMenuItem;

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = toolbarTitle;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            if (!ShowNewMenuItem)
                menu.FindItem(Resource.Id.menu_new).SetVisible(false);
            if (!ShowEditMenuItem)
                menu.FindItem(Resource.Id.menu_edit).SetVisible(false);
            if (!ShowSaveMenuItem)
                menu.FindItem(Resource.Id.menu_save).SetVisible(false);
            if (!ShowSyncImagesMenuItem)
                menu.FindItem(Resource.Id.menu_syncImages).SetVisible(false);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_new)
            {
                OnNewMenuItemClick(item);
            }
            else if (item.ItemId == Resource.Id.menu_edit)
            {
                OnEditMenuItemClick(item);
            }
            else if (item.ItemId == Resource.Id.menu_save)
            {
                OnSaveMenuItemClick(item);
            }
            else if (item.ItemId == Resource.Id.menu_syncImages)
            {
                OnSyncImagesMenuItemClick(item);
            }
            else
            {
                Toast.MakeText(this, "Action selected: " + item.TitleFormatted, ToastLength.Short).Show();
            }
            return base.OnOptionsItemSelected(item);
        }

        protected virtual void OnNewMenuItemClick(object sender) { }
        protected virtual void OnEditMenuItemClick(object sender) { }
        protected virtual void OnSaveMenuItemClick(object sender) { }
        protected virtual void OnSyncImagesMenuItemClick(object sender)
        {
            Toast.MakeText(this, "All images will be sync", ToastLength.Short).Show();

            foreach (var bt in CacheContext.BusinessTrips)
            {
                foreach (var p in bt.Pieces)
                {
                    _bitmapHelper.SyncPieceImage(p.ImageName);
                }
            }

            // Make sure it shows up in the Photos gallery promptly.
            MediaScannerConnection.ScanFile(this, new string[] { _environmentHelper.GetPhotoStorageFolder().Path }, new string[] { "image/png", "image/jpeg" }, null);
        }
        #endregion
    }
}