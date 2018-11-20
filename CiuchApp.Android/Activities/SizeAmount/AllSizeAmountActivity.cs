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
using CiuchApp.Mobile.Adapters;

namespace CiuchApp.Mobile.Activities
{

    [Activity(Label = "SizeAmount")]
    public class AllSizeAmountActivity : CiuchAppBaseActivity
    {
        private Button newSizeAmountButton;
        private ListView sizeAmountListView;
        private List<SizeAmountPair> SizeAmountPairs;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.AllSizeAmount);

            newSizeAmountButton = FindViewById<Button>(Resource.Id.newSizeAmount);
            newSizeAmountButton.Click += (s, e) => {
                var newSizeAmount = new SizeAmountPair
                {
                    PieceId = CurrentPiece.Id
                };
                CacheContext.NewSizeAmount = newSizeAmount;
                Next<NewUpdateSizeAmountActivity>(CurrentBusinessTrip.Id, CurrentPiece.Id);
            };

            sizeAmountListView = FindViewById<ListView>(Resource.Id.sizeAmountListView);
            SizeAmountPairs = CurrentPiece.SizeAmountPairs.ToList();
            var adapter = new SizeAmountListViewAdapter(this, SizeAmountPairs, _apiClient);
            sizeAmountListView.Adapter = adapter;
            sizeAmountListView.ItemClick += (s, e) =>
            {
                var itemClicked = SizeAmountPairs[e.Position];
                Next<NewUpdateSizeAmountActivity>(CurrentBusinessTrip.Id, CurrentPiece.Id, itemClicked.Id);
            };
        }
    }
}

