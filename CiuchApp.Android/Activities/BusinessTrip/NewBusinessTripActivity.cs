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

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "Nowy wyjazd", Icon = "@drawable/answear", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class NewBusinessTrips : BaseBusinessTripsActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Log.Info("CiuchApp:NewBusinessTrips", "On create");

            //Set default Model that will be pass to call
            model = new BusinessTrip
            {
                DateFrom = DateTime.Now,
                DateTo = DateTime.Now,
                CountryId = 1,
                CityId = 1,
                SeasonId = 1,
                CurrencyId = 1
            };

            base.OnCreate(bundle);

            // BUTTON - ADD NEW BUSINESS TRIP
            saveNewBusinessTrip.Text = "Dodaj Podróż";
            saveNewBusinessTrip.Click += (s, e) => {
                model = apiClientService.Add<BusinessTrip>(model);

                Next<SelectPieceActivity>(model);
            };

            //TODO: Nice info at the bottom that it was saved:
            //  Spinner spinner = (Spinner)sender;
            //  string toast = string.Format("The planet is {0}", spinner.GetItemAtPosition(e.Position));
            //  Toast.MakeText(this, toast, ToastLength.Long).Show();


        }
    }
}

