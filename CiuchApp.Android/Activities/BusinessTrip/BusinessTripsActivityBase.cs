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
    public abstract class BusinessTripsActivityBase : CiuchAppBaseActivity
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

            //SET
            //DATE PICKERS 
            //Date from
            _dateDisplayFrom = FindViewById<TextView>(Resource.Id.dateFrom);
            _dateDisplayFrom.Text = model.DateFrom.ToString("dd-MM-yyyy");
            _dateDisplayFrom.Click += (s, e) => {
                DatePickerFragment.NewInstance(delegate (DateTime date) {
                    _dateDisplayFrom.Text = date.ToString("dd-MM-yyyy");
                    model.DateFrom = date;
                }).Show(FragmentManager, DatePickerFragment.TAG); };

            //Date to
            _dateDisplayTo = FindViewById<TextView>(Resource.Id.dateTo);
            _dateDisplayTo.Text = model.DateTo.ToString("dd-MM-yyyy");
            _dateDisplayTo.Click += (s, e) => {
                DatePickerFragment.NewInstance(delegate (DateTime date) {
                    _dateDisplayTo.Text = date.ToString("dd-MM-yyyy");
                    model.DateTo = date;
                }).Show(FragmentManager, DatePickerFragment.TAG); };
            
            //DROPDOWNS Values from API
            var countries   = apiClientService.GetList<Country>().Select(x => x.Name).ToList();
            var cities      = apiClientService.GetList<City>().Select(x => x.Name).ToList();
            var seasons     = apiClientService.GetList<Season>().Select(x => x.Name).ToList();
            var currencies  = apiClientService.GetList<Currency>().Select(x => x.Name).ToList();

            //Adapters for spinners
            var adapterCountries  = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, countries);
            var adapterCities     = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, cities);
            var adapterSeasons    = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, seasons);
            var adapterCurrencies = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, currencies);

            //SPINERS (DROPDOWN) SECTION 
            _spinnerCountries = FindViewById<Spinner>(Resource.Id.countrySpinner);
            adapterCountries.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _spinnerCountries.Adapter = adapterCountries;
            _spinnerCountries.ItemSelected += (s, e) => { model.CountryId = e.Position + 1; };
            _spinnerCountries.SetSelection(--model.CountryId);

            _spinnerCities = FindViewById<Spinner>(Resource.Id.citySpinner);
            adapterCities.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _spinnerCities.Adapter = adapterCities;
            _spinnerCities.ItemSelected += (s, e) => { model.CityId = e.Position + 1; };
            _spinnerCities.SetSelection(--model.CityId);

            _spinnerSeason = FindViewById<Spinner>(Resource.Id.seasonSpinner);
            adapterSeasons.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _spinnerSeason.Adapter = adapterSeasons;
            _spinnerSeason.ItemSelected += (s, e) => { model.SeasonId = e.Position + 1; };
            _spinnerSeason.SetSelection(--model.SeasonId);

            _spinnerCurrencies = FindViewById<Spinner>(Resource.Id.currencySpinner);
            adapterCurrencies.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _spinnerCurrencies.Adapter = adapterCurrencies;
            _spinnerCurrencies.ItemSelected += (s, e) => { model.CurrencyId = e.Position + 1; };
            _spinnerCurrencies.SetSelection(--model.CurrencyId);

            // BUTTON - GET BUTTON (action in derivered classes)
            saveNewBusinessTrip = FindViewById<Button>(Resource.Id.saveNewBusinessTrip);

        }
    }
}

