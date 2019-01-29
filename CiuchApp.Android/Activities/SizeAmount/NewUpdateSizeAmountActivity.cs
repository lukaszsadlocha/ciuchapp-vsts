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

    [Activity(Label = "Rozmiar i ilość")]
    public class NewUpdateSizeAmountActivity : CiuchAppBaseActivity
    {
        Button _saveButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            SetContentView(Resource.Layout.SizeAmount);

            if(CacheContext.NewSizeAmount != null)
            {
                SetCurrentSizeAmount(CacheContext.NewSizeAmount);
            }

            //Set Text fields
            EditTextFor(Resource.Id.sizeAmountAmountEditText, CurrentSizeAmount, nameof(CurrentSizeAmount.Amount));

            //Set spinners 
            SpinnerFor<Size>(Resource.Id.sizeAmountSizeSpinner, CurrentSizeAmount, CacheContext.Sizes);
            
            //Save button
            _saveButton = FindViewById<Button>(Resource.Id.saveNewSizeAmount);
            _saveButton.Text = "Zapisz";
            _saveButton.Click += (s, e) =>
            {
                if(CurrentSizeAmount.Id==0)
                {
                    if (_apiClient.Add<SizeAmountPair>(CurrentSizeAmount))
                    {
                        CurrentSizeAmount.Size = CacheContext.Sizes.First(x => x.Id == CurrentSizeAmount.SizeId);
                        if(CurrentPiece.SizeAmountPairs == null)
                        {
                            CurrentPiece.SizeAmountPairs = new List<SizeAmountPair>();
                        }
                        CurrentPiece.SizeAmountPairs.Add(CurrentSizeAmount);
                    }
                    CacheContext.NewSizeAmount = null;
                }
                else
                {
                    _apiClient.Update<Piece>(CurrentPiece);
                }
                Next<AllSizeAmountActivity>(CurrentBusinessTrip.Id, CurrentPiece.Id);
            };
        }
    }
}

