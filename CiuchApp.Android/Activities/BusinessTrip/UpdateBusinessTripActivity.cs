using Android.App;
using Android.Widget;
using Android.OS;

using Java.IO;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;
using Android.Graphics;
using System;
using Android.Content;
using System.Collections.Generic;
using Android.Provider;
using Android.Content.PM;
using CiuchApp.Mobile;
using CiuchApp.Domain;
using CiuchApp.DataAccess;
using CiuchApp.Mobile.Adapters;
using CiuchApp.Settings;
using CiuchApp.Mobile.Extensions;
using System.Linq;
using CiuchApp.ApiClient;

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "Edytuj wyjazd", Icon = "@drawable/answear", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, NoHistory = true)]
    public class UpdateBusinessTripActivity : CiuchAppBaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewBusinessTrip);
            SetToolbar("Edytuj Wyjazd", showSaveMenuItem: true);


            //Date from

            DatePickerFor(Resource.Id.dateFrom, CurrentBusinessTrip, nameof(CurrentBusinessTrip.DateFrom));
            DatePickerFor(Resource.Id.dateTo, CurrentBusinessTrip, nameof(CurrentBusinessTrip.DateTo));

            //DROPDOWNS
            SpinnerFor<Country>(Resource.Id.countrySpinner, CurrentBusinessTrip, CacheContext.Countries);
            SpinnerFor<City>(Resource.Id.citySpinner, CurrentBusinessTrip, CacheContext.Cities);
            SpinnerFor<Currency>(Resource.Id.currencySpinner, CurrentBusinessTrip, CacheContext.Currencies);
            SpinnerFor<Season>(Resource.Id.seasonSpinner, CurrentBusinessTrip, CacheContext.Seasons);

            //// BUTTON - GET BUTTON (action in derivered classes)
            //var saveNewBusinessTrip = FindViewById<Button>(Resource.Id.saveNewBusinessTrip);

            //// BUTTON - ADD/UPDATE BUSINESS TRIP
            //saveNewBusinessTrip.Text = "Zapisz";
            //saveNewBusinessTrip.Click += (s, e) => {
            //    if(_apiClient.Update<BusinessTrip>(CurrentBusinessTrip))
            //        Next<AllBusinessTripActivity>();
            //    // TODO: log error + render error activity
            //};

            //TODO: Nice info at the bottom that it was saved:
            //  Spinner spinner = (Spinner)sender;
            //  string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            //  Toast.MakeText(this, toast, ToastLength.Long).Show();


        }

        protected override void OnSaveMenuItemClick()
        {
            if (_apiClient.Update<BusinessTrip>(CurrentBusinessTrip))
                Next<AllBusinessTripActivity>();
            base.OnSaveMenuItemClick();
        }
    }
}

