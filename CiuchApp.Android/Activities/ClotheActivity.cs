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
using CiuchApp.Android.Resources;
using CiuchApp.Domain;

namespace CiuchApp.Android.Activities
{

    [Activity(Label = "CiuchyAndroid")]
    public class ClotheActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Clothe);
            var clothe = Piece.Deserialize(Intent.GetStringExtra(Piece.JsonKey));

            if(!string.IsNullOrEmpty(clothe.ImagePath))
            {
                var image = clothe.ImagePath.LoadAndResizeBitmap(100, 100);

                FindViewById<ImageView>(Resource.Id.ClotheImage).SetImageBitmap(image);
            }

            FindViewById<NumberPicker>(Resource.Id.ClotheName).Value = clothe.Amount;
            //FindViewById<TextView>(Resource.Id.ClotheDestription).Text = clothe.Description;
            //FindViewById<TextView>(Resource.Id.ClotheNumberOfSizeS).Text = clothe.NumberOfSizeS.ToString();
            //FindViewById<TextView>(Resource.Id.ClotheNumberOfSizeM).Text = clothe.NumberOfSizeM.ToString();
            //FindViewById<TextView>(Resource.Id.ClotheNumberOfSizeL).Text = clothe.NumberOfSizeL.ToString();

        }

    }
}

