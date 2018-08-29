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
    [Activity(Label = "Ciuch", MainLauncher = true)]
    public class NewBusinessTrips : CiuchAppBaseActivity
    {
        TextView _dateDisplay;
        Button _dateSelectButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewBusinessTrip);

            //DATE PICKER
            _dateDisplay = FindViewById<TextView>(Resource.Id.dateFrom);
            _dateSelectButton = FindViewById<Button>(Resource.Id.setDateFrom);
            _dateSelectButton.Click += DateSelect_OnClick;

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
            Spinner spinnerCountries = FindViewById<Spinner>(Resource.Id.countrySpinner);
            adapterCountries.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerCountries.Adapter = adapterCountries;

            Spinner spinnerCities = FindViewById<Spinner>(Resource.Id.citySpinner);
            adapterCities.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerCities.Adapter = adapterCities;

            Spinner spinnerSeason = FindViewById<Spinner>(Resource.Id.seasonSpinner);
            adapterSeasons.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerSeason.Adapter = adapterSeasons;

            Spinner spinnerCurrencies = FindViewById<Spinner>(Resource.Id.currencySpinner);
            adapterCurrencies.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerCurrencies.Adapter = adapterCurrencies;

            //spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(Spinner_ItemSelected);

            // ADAPTER STATIC VALUES
            //var adapter = ArrayAdapter.CreateFromResource(
            //        this, Resource.Array.planets_array, Android.Resource.Layout.SimpleSpinnerItem);



            //businessTripsListView = FindViewById<ListView>(Resource.Id.businessTripsListView);

            //var ResultFromTest = restClient.TestService();

            //businessTrips = ResultFromTest;

            //var adapter = new BusinessTripListViewAdapter(this, businessTrips);
            //businessTripsListView.Adapter = adapter;
            //businessTripsListView.ItemClick += BusinessTripsListViewClicked;


            //var settings = CiuchApp.Settings.CiuchAppSettingsFactory.GetSettings();

        }

        void DateSelect_OnClick(object sender, EventArgs eventArgs)
        {
            DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
            {
                _dateDisplay.Text = time.ToLongDateString();
            });
            frag.Show(FragmentManager, DatePickerFragment.TAG);
        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            Toast.MakeText(this, toast, ToastLength.Long).Show();
        }

        //private void BusinessTripsListViewClicked(object sender, AdapterView.ItemClickEventArgs e)
        //{
        //    var businessTripClicked = businessTrips[e.Position];

        //    var nextActivity = new Intent(this, typeof(SelectPieceActivity));
        //    nextActivity.PutExtra(BusinessTrip.JsonKey, businessTripClicked.Serialize());
        //    StartActivity(nextActivity);
        //}

        //private void NewBusinessTripsClicked(object sender, AdapterView.ItemClickEventArgs e)
        //{
        //    var businessTripClicked = businessTrips[e.Position];

        //    var nextActivity = new Intent(this, typeof(SelectPieceActivity));
        //    nextActivity.PutExtra(BusinessTrip.JsonKey, businessTripClicked.Serialize());
        //    StartActivity(nextActivity);
        //}
    }
}

