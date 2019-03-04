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
using Android.Util;
using CiuchApp.ApiClient;

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "Nowy wyjazd", Icon = "@drawable/answear", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, NoHistory = true)]
    public class NewBusinessTrips : CiuchAppBaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewBusinessTrip);

            //Set default Model that will be pass to call
            var model = new BusinessTrip
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
                CountryId = 1,
                CityId = 1,
                SeasonId = 1,
                CurrencyId = 1
            };

            //Date from
            DatePickerFor(Resource.Id.dateFrom, model, nameof(model.DateFrom));
            DatePickerFor(Resource.Id.dateTo, model, nameof(model.DateTo));

            //DROPDOWNS
            SpinnerFor<Country>(Resource.Id.countrySpinner, model, CacheContext.Countries);
            SpinnerFor<City>(Resource.Id.citySpinner, model, CacheContext.Cities);
            SpinnerFor<Currency>(Resource.Id.currencySpinner, model, CacheContext.Currencies);
            SpinnerFor<Season>(Resource.Id.seasonSpinner, model, CacheContext.Seasons);

            // BUTTON - GET BUTTON (action in derivered classes)
            var saveNewBusinessTrip = FindViewById<Button>(Resource.Id.saveNewBusinessTrip);


            // BUTTON - ADD NEW BUSINESS TRIP
            saveNewBusinessTrip.Text = "Dodaj Podróż";
            saveNewBusinessTrip.Click += (s, e) => {
                if (_apiClient.Add<BusinessTrip>(model))
                    //TODO: model need to have ID as a result of call to webApi
                    CacheContext.BusinessTrips.Add(model);
                    Next<AllPieceActivity>(model.Id);
                // TODO: log error + render error activity
            };

            //TODO: Nice info at the bottom that it was saved:
            //  Spinner spinner = (Spinner)sender;
            //  string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            //  Toast.MakeText(this, toast, ToastLength.Long).Show();


        }
    }
}

