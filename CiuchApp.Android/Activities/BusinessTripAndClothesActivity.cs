using Android.App;
using Android.Widget;
using Android.OS;

using Java.IO;
using Environment = Android.OS.Environment;
using Uri = Android.Net.Uri;
using System;
using Android.Content;
using System.Collections.Generic;
using Android.Provider;
using Android.Content.PM;
using CiuchApp.Android.Resources;
using CiuchApp.Domain;
using CiuchApp.DataAccess;
using CiuchApp.Android.Adapters;
using System.Linq;

namespace CiuchApp.Android.Activities
{
    [Activity(Label = "Ciuch")]
    public class BusinessTripAndClothesActivity : CiuchAppBaseActivity
    {
        //private ImageView _imageView;
        private List<Piece> clothes;
        private ListView clothesListView;
        private BusinessTrip businessTrip;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Set Layout
            SetContentView(Resource.Layout.BusinessTripAndClothes);

            // Set Business trip info
            businessTrip = BusinessTrip.Deserialize(Intent.GetStringExtra(BusinessTrip.JsonKey));
            FindViewById<TextView>(Resource.Id.businessTripTextInfo).Text = $"{businessTrip.City} | {businessTrip.DateFrom}";

            // Load Clothes
            clothesListView = FindViewById<ListView>(Resource.Id.showClothesListView);
            clothes = ciuchAppContext.GetClothesByBusinessTripId(businessTrip.Id);

            var adapter = new ClotheListViewAdapter(this, clothes);
            clothesListView.Adapter = adapter;
            clothesListView.ItemClick += ClothesListViewClicked;

            // Set camera
            if (IsThereAnAppToTakePictures())
            {
                CreateDirectoryForPictures();
                Button button = FindViewById<Button>(Resource.Id.newClothe);
                //_imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                button.Click += TakeAPicture;
            }
        }

        private void ClothesListViewClicked(object sender, AdapterView.ItemClickEventArgs e)
        {
            var clotheClicked = clothes[e.Position];

            var nextActivity = new Intent(this, typeof(ClotheActivity));
            nextActivity.PutExtra(Piece.JsonKey, clotheClicked.Serialize());
            StartActivity(nextActivity);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            Intent mediaScanIntent = new Intent(Intent.ActionMediaScannerScanFile);
            Uri contentUri = Uri.FromFile(CameraAndImageSettings._file);
            mediaScanIntent.SetData(contentUri);
            SendBroadcast(mediaScanIntent);
            int height = Resources.DisplayMetrics.HeightPixels;
            //int width = _imageView.Height;
            int width = 100;
            CameraAndImageSettings.bitmap = CameraAndImageSettings._file.Path.LoadAndResizeBitmap(width, height);
            if (CameraAndImageSettings.bitmap != null)
            {
                //Open Clothe with image loaded and data to fill
                var newClothe = new Piece
                {
                    BusinessTripId = this.businessTrip.Id,
                    Id = ciuchAppContext.GetClothes().Max(x => x.Id) + 1,
                    ImagePath = CameraAndImageSettings._file.Path
                };

                var nextActivity = new Intent(this, typeof(ClotheActivity));
                nextActivity.PutExtra(Piece.JsonKey, newClothe.Serialize());
                StartActivity(nextActivity);
            }

            //_imageView.SetImageBitmap(CameraAndImageSettings.bitmap);
            //CameraAndImageSettings.bitmap = null;
        
            //GC.Collect();


        }
        private void CreateDirectoryForPictures()
        {
            CameraAndImageSettings._dir = new File(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures), "CiuchApp");
            if (!CameraAndImageSettings._dir.Exists())
            {
                CameraAndImageSettings._dir.Mkdirs();
            }
        }
        private bool IsThereAnAppToTakePictures()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            IList<ResolveInfo> availableActivities = PackageManager.QueryIntentActivities(intent, PackageInfoFlags.MatchDefaultOnly);
            return availableActivities != null && availableActivities.Count > 0;
        }
        private void TakeAPicture(object sender, EventArgs eventArgs)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            CameraAndImageSettings._file = new File(CameraAndImageSettings._dir, String.Format($"Clothe_{businessTrip.Country}_{businessTrip.City}_{businessTrip.DateFrom}_{Guid.NewGuid()}.jpg"));
            intent.PutExtra(MediaStore.ExtraOutput, Uri.FromFile(CameraAndImageSettings._file));
            StartActivityForResult(intent, 0);
        }
    }
}

