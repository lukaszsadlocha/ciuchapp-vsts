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
using Outcoder.UI.Xaml.Data;
using CiuchApp.Mobile.ViewModels;

namespace CiuchApp.Mobile.Activities
{

    [Activity(MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, NoHistory = true)]
    public class BindedBusinessTripActivity : CiuchAppBaseActivity
    {
        readonly XmlBindingApplicator bindingApplicator = new XmlBindingApplicator();

        public BusinessTripViewModel ViewModel { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var layoutResourceId = Resource.Layout.BindedBusinessTrip;

            SetContentView(layoutResourceId);

            ViewModel = new BusinessTripViewModel();

            bindingApplicator.ApplyBindings(this, nameof(ViewModel), layoutResourceId);
        }

        protected override void OnDestroy()
        {
            bindingApplicator.RemoveBindings();

            base.OnDestroy();
        }
    }
}

