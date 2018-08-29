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
using CiuchApp.Android;
using CiuchApp.Domain;
using CiuchApp.DataAccess;
using CiuchApp.Android.Adapters;
using CiuchApp.Settings;

namespace CiuchApp.Android.Activities
{
    [Activity(Label = "Ciuch")]
    public class NewBusinessTrips : CiuchAppBaseActivity
    {
        private List<BusinessTrip> businessTrips;
        private ListView businessTripsListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewBusinessTrip);

            //businessTripsListView = FindViewById<ListView>(Resource.Id.businessTripsListView);

            //var ResultFromTest = restClient.TestService();

            //businessTrips = ResultFromTest;

            //var adapter = new BusinessTripListViewAdapter(this, businessTrips);
            //businessTripsListView.Adapter = adapter;
            //businessTripsListView.ItemClick += BusinessTripsListViewClicked;


            //var settings = CiuchApp.Settings.CiuchAppSettingsFactory.GetSettings();

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

