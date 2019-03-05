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
using CiuchApp.ApiClient;
using Android.Views;

namespace CiuchApp.Mobile.Activities
{
    [Activity(Label = "CiuchApp - Answear")]
    public class AllBusinessTripActivity : CiuchAppBaseActivity
    {
        private Button newBusinessTripButton;
        private ListView businessTripsListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AllBusinessTrip);

            newBusinessTripButton = FindViewById<Button>(Resource.Id.newBusinessTrip);
            newBusinessTripButton.Click += (s, e) => { StartActivity(new Intent(this, typeof(NewBusinessTrips))); };

            businessTripsListView = FindViewById<ListView>(Resource.Id.businessTripsListView);

            var adapter = new BusinessTripListViewAdapter(this, CacheContext.BusinessTrips);
            businessTripsListView.Adapter = adapter;
            businessTripsListView.ItemClick += (s, e) =>
            {
                var businessTripClicked = CacheContext.BusinessTrips[e.Position];
                Next<AllPieceActivity>(businessTripClicked.Id);
            };

            businessTripsListView.ItemLongClick += (s, e) =>
            {
                var businessTripClicked = CacheContext.BusinessTrips[e.Position];

                Next<UpdateBusinessTripActivity>(businessTripClicked.Id);
            };

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "My ja jebe";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
                ToastLength.Short).Show();
            return base.OnOptionsItemSelected(item);
        }
    }
}

