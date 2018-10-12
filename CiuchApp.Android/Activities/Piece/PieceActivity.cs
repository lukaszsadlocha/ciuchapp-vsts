using System;
using System.Linq;
using System.Linq.Expressions;
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
        Button _saveButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Piece);

            var model = GetPiece();
            var businessTrip = GetBusinessTrip();


            //Set image
            if(!string.IsNullOrEmpty(model.ImageName))
            {
                string imageParh = EnvironmentHelper.GetImageFullPath(model.ImageName);
                var image = imageParh.LoadAndResizeBitmap(100, 100);

                FindViewById<ImageView>(Resource.Id.PieceImage).SetImageBitmap(image);
            }

            //Set Text fields
            EditTextFor(Resource.Id.PieceNameText, model, nameof(model.Name), "__CIUCH__");
            EditTextFor(Resource.Id.PieceBuyPriceText, model, nameof(model.BuyPrice));
            EditTextFor(Resource.Id.PieceAmountText, model, nameof(model.Amount));

            //Set spinners 
            SpinnerFor<Color>(Resource.Id.pieceColorSpinner, model);
            SpinnerFor<Group>(Resource.Id.pieceGroupSpinner, model);
            SpinnerFor<CountryOfOrigin>(Resource.Id.pieceCountryOfOriginSpinner, model);
            SpinnerFor<Component>(Resource.Id.pieceComponentSpinner, model);
            SpinnerFor<MainCategory>(Resource.Id.pieceMainCategorySpinner, model);

            SpinnerFor<Supplier>(Resource.Id.pieceSupplierSpinner, model);
            SpinnerFor<Size>(Resource.Id.pieceSizeSpinner, model);
            SpinnerFor<CodeCn>(Resource.Id.pieceCodeCnSpinner, model);
            SpinnerFor<Set>(Resource.Id.pieceSetSpinner, model);
            SpinnerFor<ColorName>(Resource.Id.pieceColorNameSpinner, model);

            //Set datetimes
            DatePickerFor(Resource.Id.PieceOrderDate, model, nameof(model.OrderDate));
            DatePickerFor(Resource.Id.PieceEstimatedDateOfShipmentDate, model, nameof(model.EstimatedDateOfShipment), DateTime.Now.AddDays(7));
            DatePickerFor(Resource.Id.PieceEstimatedTimeOfDeliveryDate, model, nameof(model.EstimatedTimeOfDelivery), DateTime.Now.AddDays(14));

            //Save button
            _saveButton = FindViewById<Button>(Resource.Id.savePieceButton);
            _saveButton.Text = "Zapisz";
            _saveButton.Click += (s, e) =>
            {
                if(model.Id==0)
                {
                    apiClientService.Add<Piece>(model);
                }
                else
                {
                    apiClientService.Update<Piece>(model);
                }
                Next<SelectPieceActivity>(businessTrip);
            };
        }
    }
}

