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

using System.IO;
using Android.Graphics;
using System.Net;
using CiuchApp.Settings;
using Android.Media;

namespace CiuchApp.Mobile.Helpers
{
    public class BitmapHelper : IBitmapHelper
    {
        private readonly IEnvironmentHelper _environmentHelper;
        private readonly ICiuchAppSettings _settings;

        public BitmapHelper(IEnvironmentHelper environmentHelper, ICiuchAppSettings ciuchAppSettings)
        {
            _environmentHelper = environmentHelper;
            _settings = ciuchAppSettings;
        }
        public void SyncPieceImage(string imageName)
        {
            //Check if image exisit
            var imagePath = _environmentHelper.GetImageFullPath(imageName);
            if (imagePath.FileExist()) return;
            //Get Image
            var image = GetImageBitmapFromImageName(imageName);

            if (image == null) return;

            // Save Image
            SaveBitmapImage(image, imageName);
        }


        private Bitmap GetImageBitmapFromImageName(string imageName)
        {
            var imageUrl = $"{_settings.Urls.RemoteUrl}/{_settings.PhotoStorageFolder.Server.Name}/{imageName}";
            return GetImageBitmapFromUrl(imageUrl);
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                try
                {
                    var imageBytes = webClient.DownloadData(url);
                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                    }
                }
                catch
                {
                    //to do fix it
                    return null;
                }
            }

            return imageBitmap;
        }

        private void SaveBitmapImage(Bitmap bitmap, string imageName)
        {
            var dir = _environmentHelper.GetPhotoStorageFolder();
            if (!dir.Exists())
            {
                dir.Mkdirs();
            }

            var pathToImage = _environmentHelper.GetImageFullPath(imageName);

            using (var s = new FileStream(pathToImage, FileMode.CreateNew))
            {
                bitmap.Compress(Bitmap.CompressFormat.Jpeg, 90, s);
            }
        }
    }
}