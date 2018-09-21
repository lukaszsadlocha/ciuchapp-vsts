using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using CiuchApp.Mobile.Helpers;
using CiuchApp.Domain;

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

            SpinnerFor<Color>(Resource.Id.pieceColorSpinner, piece);
            SpinnerFor<Group>(Resource.Id.pieceGroupSpinner, piece);
            SpinnerFor<CountryOfOrigin>(Resource.Id.pieceCountryOfOriginSpinner, piece);
            SpinnerFor<Component>(Resource.Id.pieceComponentSpinner, piece);
            SpinnerFor<MainCategory>(Resource.Id.pieceMainCategorySpinner, piece);
        }
    }
}

