﻿using Android.App;
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

namespace CiuchApp.Mobile.Activities
{
    [Activity(Label = "Ciuch")]
    public class ListBusinessTrips : CiuchAppBaseActivity
    {
        private Button newBusinessTripButton;
        private ListView businessTripsListView;
        private List<BusinessTrip> businessTrips;
        


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SelectBusinessTrip);

            newBusinessTripButton = FindViewById<Button>(Resource.Id.newBusinessTrip);
            newBusinessTripButton.Click += NewBusinessTripClicked;

            //Get Business trips and show them in ListView + add events 
            businessTrips = apiClientService.GetList<BusinessTrip>();
            businessTripsListView = FindViewById<ListView>(Resource.Id.businessTripsListView);

            var adapter = new BusinessTripListViewAdapter(this, businessTrips);
            businessTripsListView.Adapter = adapter;
            businessTripsListView.ItemClick += BusinessTripsListViewClicked;

            var settings = CiuchApp.Settings.CiuchAppSettingsFactory.GetSettings();


        }

        private void BusinessTripsListViewClicked(object sender, AdapterView.ItemClickEventArgs e)
        {
            var businessTripClicked = businessTrips[e.Position];

            var nextActivity = new Intent(this, typeof(SelectPieceActivity));
            nextActivity.PutExtra(BusinessTrip.JsonKey, businessTripClicked.Serialize());
            StartActivity(nextActivity);
        }

        private void NewBusinessTripClicked(object sender, EventArgs eventArgs)
        {
            StartActivity(new Intent(this, typeof(NewBusinessTrips)));
        }
    }
}
