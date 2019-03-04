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
using System.Threading.Tasks;
using Android.Util;

namespace CiuchApp.Mobile.Activities
{
    [Activity(Theme = "@style/CiuchAppSplash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : CiuchAppBaseActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { LoadCacheAsync(); });
            startupWork.Start();
            Toast.MakeText(this, "Ładuję dane...", ToastLength.Long).Show();
            Toast.MakeText(this, "Ładuję dane...", ToastLength.Long).Show();
        }

        // Simulates background work that happens behind the splash screen
        async void LoadCacheAsync()
        {
            try
            {
                _cacheContext = await _apiClient.GetCacheAsync();
            }
            catch (Exception e)
            {
                Log.Debug("CiuchAppSplash", "Error in loading cache");
                RunOnUiThread(() => Toast.MakeText(this, "Nie można pobrać danych. Spróbuj ponownie", ToastLength.Long).Show());
                return;
            }

            Next<AllBusinessTripActivity>();
        }
    }
}