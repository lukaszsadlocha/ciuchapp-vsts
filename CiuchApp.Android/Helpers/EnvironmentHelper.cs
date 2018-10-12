using System;
using System.IO;
using Android.OS;
using CiuchApp.Settings;
using Java.IO;

namespace CiuchApp.Mobile.Helpers
{
    public static class EnvironmentHelper
    {
        private readonly static CiuchAppSettings Settings = CiuchAppSettingsFactory.GetSettings();

        private static Java.IO.File LocalStorageFolder()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures);
        }

        public static Java.IO.File GetPhotoStorageFolder()
        {
            return new Java.IO.File(LocalStorageFolder(), Settings.PhotoStorageFolder.Mobile.Name);
        }

        internal static string GetImageFullPath(string imageName)
        {
            return Path.Combine(GetPhotoStorageFolder().ToString(), imageName);
        }
    }
}