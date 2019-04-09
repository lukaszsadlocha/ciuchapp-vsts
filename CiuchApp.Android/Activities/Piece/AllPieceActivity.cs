using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Widget;
using CiuchApp.ApiClient;
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
    [Activity]
    public class AllPieceActivity : CiuchAppBaseActivity
    {
        //controls
        private ListView piecesListView;

        //Helper class to be passed to take picture Intent
        public static class App
        {
            public static File _file;
            public static File _dir;
            public static Bitmap bitmap;
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set Layout
            SetContentView(Resource.Layout.AllPiece);

            var toolbarTitle = $"{CurrentBusinessTrip?.City?.Name} | {CurrentBusinessTrip?.DateFrom.ToString("dd MM yyyy")}";
            SetToolbar(toolbarTitle, showNewMenuItem: true);

            piecesListView = FindViewById<ListView>(Resource.Id.showClothesListView);

            // Load Clothes
            var pieces = CurrentBusinessTrip.Pieces.ToList();
            
            var adapter = new PieceListViewAdapter(this, pieces, _environmentHelper);
            piecesListView.Adapter = adapter;
            piecesListView.ItemClick += (s, e) =>
            {
                var pieceClicked = pieces[e.Position];
                Next<NewUpdatePieceActivity>(CurrentBusinessTrip.Id, pieceClicked.Id);
            };

            //Handle camera

            if (IsThereAnAppToTakePictures())
            {
                EnsureDirectoryForPictures();
            }
        }

        protected override void OnNewMenuItemClick(object sender)
        {
            TakeAPicture(sender, null);
        }

        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            App._file = new File(App._dir, String.Format("myPhoto_{0}.jpg", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(App._file));
            StartActivityForResult(intent, 0);
        }

        private void EnsureDirectoryForPictures()
        {
            App._dir = _environmentHelper.GetPhotoStorageFolder();
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
                //TODO: Make coupe sizes of images:
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

                _apiClient.UploadImage(fpath, fname);


                App.bitmap = null;
            }

            // Dispose of the Java side bitmap.
            GC.Collect();

            var newPieceWithImage = new Piece
            {
                BusinessTripId = CurrentBusinessTrip.Id,
                ImageName = App._file.Name
            };

            CacheContext.NewPiece = newPieceWithImage;

            Next<NewUpdatePieceActivity>(CurrentBusinessTrip.Id);
        }
    }
}

