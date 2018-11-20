using System;
using System.Linq;
using System.Linq.Expressions;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using CiuchApp.Mobile.Helpers;
using CiuchApp.Domain;
using CiuchApp.Settings;
using CiuchApp.ApiClient;
using System.Collections.Generic;

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "Ciuch")]
    public class NewUpdatePieceActivity : CiuchAppBaseActivity
    {
        Button _saveButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Piece);

            if(CacheContext.NewPiece != null)
            {
                SetCurrentPiece(CacheContext.NewPiece);
            }

            //Set image
            if(!string.IsNullOrEmpty(CurrentPiece.ImageName))
            {
                string imageParh = _environmentHelper.GetImageFullPath(CurrentPiece.ImageName);
                var image = imageParh.LoadAndResizeBitmap(100, 100);

                FindViewById<ImageView>(Resource.Id.PieceImage).SetImageBitmap(image);
            }

            //Set Text fields
            EditTextFor(Resource.Id.PieceNameText, CurrentPiece, nameof(CurrentPiece.Name));
            EditTextFor(Resource.Id.PieceBuyPriceText, CurrentPiece, nameof(CurrentPiece.BuyPrice));

            //Set spinners 
            SpinnerFor<Color>(Resource.Id.pieceColorSpinner, CurrentPiece);
            SpinnerFor<Group>(Resource.Id.pieceGroupSpinner, CurrentPiece);
            SpinnerFor<CountryOfOrigin>(Resource.Id.pieceCountryOfOriginSpinner, CurrentPiece);
            SpinnerFor<Component>(Resource.Id.pieceComponentSpinner, CurrentPiece);
            SpinnerFor<MainCategory>(Resource.Id.pieceMainCategorySpinner, CurrentPiece);

            SpinnerFor<Supplier>(Resource.Id.pieceSupplierSpinner, CurrentPiece);
            SpinnerFor<CodeCn>(Resource.Id.pieceCodeCnSpinner, CurrentPiece);
            SpinnerFor<Set>(Resource.Id.pieceSetSpinner, CurrentPiece);
            SpinnerFor<ColorName>(Resource.Id.pieceColorNameSpinner, CurrentPiece);

            //Set datetimes
            DatePickerFor(Resource.Id.PieceOrderDate, CurrentPiece, nameof(CurrentPiece.OrderDate));
            DatePickerFor(Resource.Id.PieceEstimatedDateOfShipmentDate, CurrentPiece, nameof(CurrentPiece.EstimatedDateOfShipment), DateTime.Now.AddDays(7));
            DatePickerFor(Resource.Id.PieceEstimatedTimeOfDeliveryDate, CurrentPiece, nameof(CurrentPiece.EstimatedTimeOfDelivery), DateTime.Now.AddDays(14));

            //Set SizeAmount
            TextView sizeAmountTextView = FindViewById<TextView>(Resource.Id.pieceSizeAmountText);
            var sizeAmountText = "";
            if(CurrentPiece.SizeAmountPairs!=null)
            {
                foreach (var item in CurrentPiece.SizeAmountPairs)
                {
                    sizeAmountText += item.Size.Name;
                    sizeAmountText += ": ";
                    sizeAmountText += item.Amount;
                    sizeAmountText += "\n";
                }
            }
            if(CurrentPiece.Id == 0)
            {
                sizeAmountText += "Zapisz Ciuch by móc dodawać rozmiary";
                sizeAmountTextView.Text = sizeAmountText;
            }
            else
            {
                sizeAmountText += "Naciśnij by edytować";
                sizeAmountTextView.Text = sizeAmountText;
                sizeAmountTextView.Click += (s, e) =>
                {
                    Next<AllSizeAmountActivity>(CurrentBusinessTrip.Id, CurrentPiece.Id);
                };
            }

            //Save button
            _saveButton = FindViewById<Button>(Resource.Id.savePieceButton);
            _saveButton.Text = "Zapisz";
            _saveButton.Click += (s, e) =>
            {
                if(CurrentPiece.Id==0)
                {
                    _apiClient.Add<Piece>(CurrentPiece);
                    CurrentBusinessTrip.Pieces.Add(CurrentPiece);
                    CacheContext.NewPiece = null;
                }
                else
                {
                    _apiClient.Update<Piece>(CurrentPiece);
                }
                Next<AllPieceActivity>(CurrentBusinessTrip.Id);
            };
        }
    }
}

