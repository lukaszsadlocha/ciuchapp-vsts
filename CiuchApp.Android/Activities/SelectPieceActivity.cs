﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Widget;
using CiuchApp.Domain;
using CiuchApp.Mobile.Adapters;
using CiuchApp.Mobile.Helpers;
using CiuchApp.Settings;
using Java.IO;
using Java.Nio;
using System;
using System.Collections.Generic;
using System.Linq;
using static Android.Graphics.Bitmap;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;

namespace CiuchApp.Mobile.Activities
{
    [Activity(Label = "Ciuchy z wyjazdu")]
    public class SelectPieceActivity : CiuchAppBaseActivity
    {
        //controls
        private Button newPiece;
        private ListView clothesListView;

        //models
        private List<Piece> clothes;
        private BusinessTrip businessTrip;

        //Helper class to be passed to take picture Intent
        public static class App
        {
            public static File _file;
            public static File _dir;
            public static Bitmap bitmap;
        }

        public SelectPieceActivity()
        {
            var settings = CiuchAppSettingsFactory.GetSettings();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set Layout
            SetContentView(Resource.Layout.SelectPiece);

            // Set Business trip info
            businessTrip = BusinessTrip.Deserialize(Intent.GetStringExtra(BusinessTrip.JsonKey));
            FindViewById<TextView>(Resource.Id.businessTripTextInfo).Text = $"{businessTrip.City} | {businessTrip.DateFrom}";

            // Load Clothes
            clothesListView = FindViewById<ListView>(Resource.Id.showClothesListView);
            clothes = apiClientService.GetPiecesByBusinessTripId(businessTrip.Id);

            var adapter = new PieceListViewAdapter(this, clothes);
            clothesListView.Adapter = adapter;
            clothesListView.ItemClick += (s, e) =>
            {
                var clotheClicked = clothes[e.Position];

                var nextActivity = new Intent(this, typeof(PieceActivity));
                nextActivity.PutExtra(Piece.JsonKey, clotheClicked.Serialize());
                StartActivity(nextActivity);
            };

            //Handle camera

            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();

                Button button = FindViewById<Button>(Resource.Id.newClothe);
                //_imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Click += TakeAPicture;
            }
        }

        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            App._file = new File(App._dir, String.Format("myPhoto_{0}.jpg", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(App._file));
            StartActivityForResult(intent, 0);
        }

        private void CreateDirectoryForPictures()
        {
            App._dir = new File(
                Environment.GetExternalStoragePublicDirectory(
                    Environment.DirectoryPictures), "CameraAppDemo");
            if (!App._dir.Exists())
            {
                App._dir.Mkdirs();
            }
        }

        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities =
                PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }


        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            // Make it available in the gallery

            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(App._file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);

            // Display in ImageView. We will resize the bitmap to fit the display.
            // Loading the full sized image will consume to much memory
            // and cause the application to crash.

            int height = Resources.DisplayMetrics.HeightPixels;
            int width = 300; //_imageView.Height;
            App.bitmap = App._file.Path.LoadAndResizeBitmap(width, height);
            if (App.bitmap != null)
            {
                //_imageView.SetImageBitmap(App.bitmap);

                //byte[] bitmapData;
                //using (var stream = new System.IO.MemoryStream())
                //{
                //    App.bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
                //    bitmapData = stream.ToArray();
                //    apiClientService.UploadImage(stream, App._file.Name);
                //}

                var fpath = App._file.Path;
                var fname = App._file.Name;

                apiClientService.UploadImage(fpath, fname);


                App.bitmap = null;
            }

            // Dispose of the Java side bitmap.
            GC.Collect();
        }
    }
}

