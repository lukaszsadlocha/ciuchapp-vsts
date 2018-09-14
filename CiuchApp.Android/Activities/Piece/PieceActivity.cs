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
using CiuchApp.Mobile.Helpers;
using CiuchApp.Domain;
using System.Linq;

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "Ciuch")]
    public class PieceActivity : CiuchAppBaseActivity
    {
        

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Piece);

            var piece = Piece.Deserialize(Intent.GetStringExtra(Piece.JsonKey));

            if(!string.IsNullOrEmpty(piece.ImagePath))
            {
                var image = piece.ImagePath.LoadAndResizeBitmap(100, 100);

                FindViewById<ImageView>(Resource.Id.PieceImage).SetImageBitmap(image);
            }

            SpinnerFor<Group>(Resource.Id.pieceGroupSpinner, piece);
        }
    }
}

