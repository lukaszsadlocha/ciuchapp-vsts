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

            var model = GetPiece();
            var businessTrip = GetBusinessTrip();

            if(!string.IsNullOrEmpty(model.ImagePath))
            {
                var image = model.ImagePath.LoadAndResizeBitmap(100, 100);

                FindViewById<ImageView>(Resource.Id.PieceImage).SetImageBitmap(image);
            }

            SpinnerFor<Color>(Resource.Id.pieceColorSpinner, model);
            SpinnerFor<Group>(Resource.Id.pieceGroupSpinner, model);
            SpinnerFor<CountryOfOrigin>(Resource.Id.pieceCountryOfOriginSpinner, model);
            SpinnerFor<Component>(Resource.Id.pieceComponentSpinner, model);
            SpinnerFor<MainCategory>(Resource.Id.pieceMainCategorySpinner, model);

            //Save button


            var button = FindViewById<Button>(Resource.Id.savePieceButton);
            button.Text = "Zapisz";
            button.Click += (s, e) =>
            {
                apiClientService.Update<Piece>(model);
                Next<SelectPieceActivity>(businessTrip);
            };
        }
    }
}

