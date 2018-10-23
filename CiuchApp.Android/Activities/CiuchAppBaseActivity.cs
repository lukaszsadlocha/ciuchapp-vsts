using Android.App;
using CiuchApp.DataAccess;
using CiuchApp.ApiClient;
using Android.Content;
using System.Linq;
using Android.Widget;
using CiuchApp.Domain;
using System;
using CiuchApp.Mobile.Extensions;
using System.Linq.Expressions;

namespace CiuchApp.Mobile.Activities
{
    public abstract class CiuchAppBaseActivity : Activity
    {
        protected CiuchApp.ApiClient.ApiClient apiClientService = new CiuchApp.ApiClient.ApiClient();

        protected void Next<T>(BusinessTrip businessTrip) where T : Activity
        {
            Next<T>(businessTrip, null);
        }

        protected void Next<T>(BusinessTrip businessTrip, Piece piece) where T : Activity
        {
            var nextActivity = new Intent(this, typeof(T));

            if (businessTrip != null)
            {
                nextActivity.PutExtra(BusinessTrip.JsonKey, businessTrip.Serialize());
            }
            if (piece != null)
            {
                nextActivity.PutExtra(Piece.JsonKey, piece.Serialize());
            }

            StartActivity(nextActivity);
        }
        protected void Next<T>() where T : Activity
        {
            Next<T>(null, null);
        }

        protected Piece GetPiece()
        {
            return Piece.Deserialize(Intent.GetStringExtra(Piece.JsonKey));
        }

        protected BusinessTrip GetBusinessTrip()
        {
            return BusinessTrip.Deserialize(Intent.GetStringExtra(BusinessTrip.JsonKey));
        }

        protected void DatePickerFor(int datePickerId, object model, string dateFieldName)
        {
            DatePickerFor(datePickerId, model, dateFieldName, DateTime.Now);
        }

        protected void DatePickerFor(int datePickerId, object model, string dateFieldName, DateTime defaultValue)
        {
            var _datePicker = FindViewById<TextView>(datePickerId);

            var dateTimeValue = GetValue(model, dateFieldName);
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

            if (defaultValue != null)
            {
                SetValue(model, fieldName, defaultValue);
            }

            _editText.TextChanged += (s, e) =>
            {
                SetValue(model, fieldName, _editText.Text);
            };
        }

        protected void SpinnerFor<T>(int spinnerId, object model) where T : DropDownValueBase
        {
            var values = apiClientService.GetList<T>().Select(x => x.Name).ToList();
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, values);
            var spinner = FindViewById<Spinner>(spinnerId);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;
            spinner.SetSelection(GetValue<T>(model) - 1);
            spinner.ItemSelected += (s, e) => { SetValue<T>(model, e.Position + 1); };
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

        protected static DateTime GetValue(object model, string fieldName)
        {
            var prop = model.GetType().GetProperties().Where(x => x.Name == fieldName).FirstOrDefault();
            if (prop != null)
            {
                return DateTime.Parse(model.GetType().GetProperty(prop.Name).GetValue(model, null).ToString());
            }
            throw new NullReferenceException();
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

            if(value == null)
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
            builder.SetNeutralButton("OK", delegate {
                funcOnClick();
                builder.Dispose(); });
            builder.Show();
        }
    }
}