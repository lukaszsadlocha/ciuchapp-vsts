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

namespace CiuchApp.Mobile.Activities
{
    public abstract class BaseBusinessTripsActivity : CiuchAppBaseActivity
    {
        //Controls
        protected TextView _dateDisplayFrom;
        protected TextView _dateDisplayTo;
        protected Spinner _spinnerCountries;
        protected Spinner _spinnerCities;
        protected Spinner _spinnerSeason;
        protected Spinner _spinnerCurrencies;
        protected Button saveNewBusinessTrip;

        //Model 
        protected BusinessTrip model;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewBusinessTrip);

            //Date from

            DatePickerFor(Resource.Id.dateFrom, model.DateFrom);
            DatePickerFor(Resource.Id.dateTo, model.DateTo);

            //DROPDOWNS
            SpinnerFor<Country>(Resource.Id.countrySpinner, model);
            SpinnerFor<City>(Resource.Id.citySpinner, model);
            SpinnerFor<Currency>(Resource.Id.currencySpinner, model);
            SpinnerFor<Season>(Resource.Id.seasonSpinner, model);

            // BUTTON - GET BUTTON (action in derivered classes)
            saveNewBusinessTrip = FindViewById<Button>(Resource.Id.saveNewBusinessTrip);

        }
    }
}

