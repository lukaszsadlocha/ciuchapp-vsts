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
using System.Net;
using System.Linq;
using System.IO;
using CiuchApp.Mobile.Helpers;
using Android.Media;

namespace CiuchApp.Mobile.Activities
{
    [Activity]
    public class AllBusinessTripActivity : CiuchAppBaseActivity
    {
        private ListView businessTripsListView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AllBusinessTrip);

            SetToolbar(toolbarTitle: "Wyjazdy służbowe", showNewMenuItem: true);

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
        }

        protected override void OnNewMenuItemClick(object sender) => Next<NewBusinessTrips>();
        protected override void OnSyncImagesMenuItemClick(object sender)
        {
            Toast.MakeText(this, "All images will be sync", ToastLength.Short).Show();

            foreach (var bt in CacheContext.BusinessTrips)
            {
                foreach (var p in bt.Pieces)
                {
                    var imageName = p.ImageName;
                    //Check if image exisit
                    var imagePath = _environmentHelper.GetImageFullPath(imageName);
                    if (imagePath.FileExist()) continue;
                    //Get Image
                    var image = GetImageBitmapFromImageName(imageName);

                    if (image == null) continue;

                    // Save Image
                    SaveBitmapImage(image, imageName);
                }
            }
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

        public void SaveBitmapImage(Bitmap bitmap, string imageName)
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

            // Make sure it shows up in the Photos gallery promptly.
            MediaScannerConnection.ScanFile(this, new string[] { pathToImage }, new string[] { "image/png", "image/jpeg" }, null);
        }
    }
}

