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

    [Activity(Label = "Nowy wyjazd", Icon = "@drawable/answear", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class UpdateBusinessTripActivity : BaseBusinessTripsActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            //Get model
            model = BusinessTrip.Deserialize(Intent.GetStringExtra(BusinessTrip.JsonKey));

            base.OnCreate(bundle);

            // BUTTON - ADD/UPDATE BUSINESS TRIP
            saveNewBusinessTrip.Text = "Zapisz";
            saveNewBusinessTrip.Click += (s, e) => {
                if(_apiClient.Update<BusinessTrip>(model))
                    Next<SelectBusinessTripActivity>();
                // TODO: log error + render error activity
            };

            //TODO: Nice info at the bottom that it was saved:
            //  Spinner spinner = (Spinner)sender;
            //  string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            //  Toast.MakeText(this, toast, ToastLength.Long).Show();


        }
    }
}

