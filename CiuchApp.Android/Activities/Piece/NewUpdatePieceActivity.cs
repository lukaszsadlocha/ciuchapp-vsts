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

    [Activity(NoHistory = true)]
    public class NewUpdatePieceActivity : CiuchAppBaseActivity
    {
        Button _saveButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.Piece);
            SetToolbar("Ciuch z wyjazdu", showSaveMenuItem: true);

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
            SpinnerFor<Color>(Resource.Id.pieceColorSpinner, CurrentPiece, CacheContext.Colors);
            SpinnerFor<CountryOfOrigin>(Resource.Id.pieceCountryOfOriginSpinner, CurrentPiece, CacheContext.CountryOfOrigin);
            SpinnerFor<Component>(Resource.Id.pieceComponentSpinner, CurrentPiece, CacheContext.Components);

            SpinnerFor<Supplier>(Resource.Id.pieceSupplierSpinner, CurrentPiece, CacheContext.Suppliers);
            SpinnerFor<CodeCn>(Resource.Id.pieceCodeCnSpinner, CurrentPiece, CacheContext.CodeCns);
            SpinnerFor<Set>(Resource.Id.pieceSetSpinner, CurrentPiece, CacheContext.Sets);
            SpinnerFor<ColorName>(Resource.Id.pieceColorNameSpinner, CurrentPiece, CacheContext.ColorNames);

            //Set cascade dropdowns
            var topCategorySpinner = SpinnerFor<TopCategory>(Resource.Id.pieceTopCategorySpinner, CurrentPiece, CacheContext.TopCategories);

            //this need to be outside event scope:
            List<MainCategory> mainCategoryRelatedValues;
            List<Group> groupRelatedValues;

            topCategorySpinner.ItemSelected += (s, e) =>
            {
                mainCategoryRelatedValues = GetCurrentTopCategory().MainCategories;
                //check if it is correctuly set:
                var currentMainCategoryId = GetValue<MainCategory>(CurrentPiece);
                if (!mainCategoryRelatedValues.Any(x => x.Id == currentMainCategoryId))
                {
                    currentMainCategoryId = mainCategoryRelatedValues.First().Id;
                    SetValue<MainCategory>(CurrentPiece, currentMainCategoryId);
                }

                var mainCategoryAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, mainCategoryRelatedValues.Select(x => x.Name).ToList());
                var mainCategorySpinner = FindViewById<Spinner>(Resource.Id.pieceMainCategorySpinner);
                mainCategoryAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                mainCategorySpinner.Adapter = mainCategoryAdapter;

                //here - position should be passed  - not ID (Id might be higher then table range -> out of range exception
                var mainCategoryPositionToSet = mainCategoryRelatedValues.FindIndex(x => x.Id == currentMainCategoryId);
                mainCategorySpinner.SetSelection(mainCategoryPositionToSet);

                mainCategorySpinner.ItemSelected += (ss, ee) => 
                {
                    var mainCategoryCurrentItem = mainCategoryRelatedValues[ee.Position];
                    SetValue<MainCategory>(CurrentPiece, mainCategoryCurrentItem.Id);

                    //Main Category Triggers Group
                    groupRelatedValues = mainCategoryCurrentItem.Groups;
                    //check if it is correctuly set:
                    var currentGroupId = GetValue<Group>(CurrentPiece);
                    if(!groupRelatedValues.Any(x=>x.Id == currentGroupId))
                    {
                        currentGroupId = groupRelatedValues.First().Id;
                        SetValue<Group>(CurrentPiece, currentGroupId);
                    }
                    var groupAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, groupRelatedValues.Select(x => x.Name).ToList());
                    var groupSpinner = FindViewById<Spinner>(Resource.Id.pieceGroupSpinner);
                    groupAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                    groupSpinner.Adapter = groupAdapter;

                    //here - position should be passed  - not ID (Id might be higher then table range -> out of range exception
                    var groupPositionToSet = groupRelatedValues.FindIndex(x => x.Id == currentGroupId);
                    groupSpinner.SetSelection(groupPositionToSet);

                    groupSpinner.ItemSelected += (sss, eee) =>
                    {
                        var groupCurrentItem = groupRelatedValues[eee.Position];
                        SetValue<Group>(CurrentPiece, groupCurrentItem.Id);
                    };
                };
            };

            //Set datetimes
            DatePickerFor(Resource.Id.PieceOrderDate, CurrentPiece, nameof(CurrentPiece.OrderDate));
            DatePickerFor(Resource.Id.PieceEstimatedDateOfShipmentDate, CurrentPiece, nameof(CurrentPiece.EstimatedDateOfShipment), DateTime.Now.AddDays(7));
            DatePickerFor(Resource.Id.PieceEstimatedTimeOfDeliveryDate, CurrentPiece, nameof(CurrentPiece.EstimatedTimeOfDelivery), DateTime.Now.AddDays(14));

            #region Set SizeAmount Logic
            //Set SizeAmount
            TextView sizeAmountTextView = FindViewById<TextView>(Resource.Id.pieceSizeAmountText);
            var sizeAmountText = "";
            if (CurrentPiece.SizeAmountPairs != null)
            {
                foreach (var item in CurrentPiece.SizeAmountPairs)
                {
                    sizeAmountText += item.Size.Name;
                    sizeAmountText += ": ";
                    sizeAmountText += item.Amount;
                    sizeAmountText += "\n";
                }
            }
            if (CurrentPiece.Id == 0)
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
            #endregion

            //Save button
            _saveButton = FindViewById<Button>(Resource.Id.savePieceButton);
            _saveButton.Text = "Zapisz";
            _saveButton.Click += (s, e) => OnSaveMenuItemClick(s);
        }

        private TopCategory GetCurrentTopCategory()
        {
            var topCategoryValues = CacheContext.TopCategories;
            int currentTopCategoryValueId = GetValue<TopCategory>(CurrentPiece) == 0 ? 1 : GetValue<TopCategory>(CurrentPiece);
            var topCategoryValue = topCategoryValues.First(x => x.Id == currentTopCategoryValueId);
            return topCategoryValue;
        }

        protected override void OnSaveMenuItemClick(object sender)
        {

            if (CurrentPiece.Id == 0)
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

            base.OnSaveMenuItemClick(sender);
        }
    }
}

