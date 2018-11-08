using System;
using System.IO;
using Android.OS;
using CiuchApp.Settings;
using Java.IO;

namespace CiuchApp.Mobile.Helpers
{
    public interface IEnvironmentHelper
    {
        string GetImageFullPath(string imageName);
        Java.IO.File GetPhotoStorageFolder();
    }
    public class EnvironmentHelper : IEnvironmentHelper
    {
        private readonly ICiuchAppSettings _settings;

        public EnvironmentHelper(ICiuchAppSettings settings)
        {
            this._settings = settings;
        }

        private Java.IO.File LocalStorageFolder()
        {
            return Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures);
        }

        public Java.IO.File GetPhotoStorageFolder()
        {
            return new Java.IO.File(LocalStorageFolder(), _settings.PhotoStorageFolder.Mobile.Name);
        }

        public string GetImageFullPath(string imageName)
        {
            return Path.Combine(GetPhotoStorageFolder().ToString(), imageName);
        }
    }
}