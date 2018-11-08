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

namespace CiuchApp.Mobile.Activities
{
    [Activity(Label = "CiuchApp - Answear", MainLauncher = true)]
    public class SelectBusinessTripActivity : CiuchAppBaseActivity
    {
        private TextView loadingText;
        private Button newBusinessTripButton;
        private ListView businessTripsListView;
        private List<BusinessTrip> businessTrips;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.SelectBusinessTrip);

            loadingText = FindViewById<TextView>(Resource.Id.loadingText);
            loadingText.Text = $"Łacze z: {_settings.Urls.ApiUrl}";

            newBusinessTripButton = FindViewById<Button>(Resource.Id.newBusinessTrip);
            newBusinessTripButton.Click += (s, e) => { StartActivity(new Intent(this, typeof(NewBusinessTrips))); };

            // Try get Business trips from previous action.
            // If null then call to api
            // finally show them in ListView + add events 

            businessTrips = GetBusinessTrips();
            if(businessTrips == null)
            {
                try
                {
                    businessTrips = _apiClient.GetList<BusinessTrip>();
                }
                catch (Exception e)
                {
                    loadingText.Text = e.Message;
                    return;
                }
            }

            businessTripsListView = FindViewById<ListView>(Resource.Id.businessTripsListView);

            var adapter = new BusinessTripListViewAdapter(this, businessTrips);
            businessTripsListView.Adapter = adapter;
            businessTripsListView.ItemClick += (s, e) => {
                var businessTripClicked = businessTrips[e.Position];

                Next<SelectPieceActivity>(businessTripClicked);
            };

            businessTripsListView.ItemLongClick += (s, e) => {
                var businessTripClicked = businessTrips[e.Position];

                Next<UpdateBusinessTripActivity>(businessTripClicked);
            };
        }
    }
}

