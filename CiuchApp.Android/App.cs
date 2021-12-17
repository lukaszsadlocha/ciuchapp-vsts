using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CiuchApp.Mobile.Helpers;
using CiuchApp.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace CiuchApp.Mobile
{
//    #if DEBUG
//[assembly: Application(Debuggable = true)]
//#else
//[assembly: Application(Debuggable=false)]
//#endif


    [Application(Icon = "@drawable/logo", Label = "@string/app_name")]
    public class App : Application
    {
        public static IServiceProvider Container { get; private set; }

        public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
        {
        }

        public override void OnCreate()
        {
            RegisterServices();
            base.OnCreate();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            services.AddTransient<ICiuchAppSettings, CiuchAppSettings>();
            services.AddTransient<ApiClient.IApiClient, ApiClient.ApiClient>();
            services.AddTransient<IEnvironmentHelper, EnvironmentHelper>();
            services.AddTransient<IBitmapHelper, BitmapHelper>();

            Container = services.BuildServiceProvider();
        }
    }
}