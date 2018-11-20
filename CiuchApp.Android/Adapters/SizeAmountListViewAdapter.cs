using Android.App;
using Android.Views;
using Android.Widget;
using CiuchApp.ApiClient;
using CiuchApp.Domain;
using Java.Lang;
using System.Collections.Generic;

namespace CiuchApp.Mobile.Adapters
{
    public class SizeAmountViewHolder : Java.Lang.Object
    {
        public TextView Country { get; set; }
        public TextView City { get; set; }
        public TextView Date { get; set; }
    }
    public class SizeAmountListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private IList<SizeAmountPair> sizeAmountPairs;
        private IApiClient _apiClient;

        public SizeAmountListViewAdapter(Activity activity, IList<SizeAmountPair> sizeAmountPairs, IApiClient apiClient)
        {
            this.activity = activity;
            this.sizeAmountPairs = sizeAmountPairs;
            _apiClient = apiClient;

        }

        public override int Count => sizeAmountPairs.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return sizeAmountPairs[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //View
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.SizeAmountRow, parent, false);

            //Size control
            var sizeName = view.FindViewById<TextView>(Resource.Id.sizeAmountRowSizeName);
            sizeName.Text = sizeAmountPairs[position].Size.Name;

            //Amout Control
            var amount =  view.FindViewById<EditText>(Resource.Id.sizeAmountRowAmount);
            amount.Text = sizeAmountPairs[position].Amount.ToString();

            amount.TextChanged += (s, e) =>
            {
                if(int.TryParse(amount.Text, out int result))
                {
                    sizeAmountPairs[position].Amount = result;
                }
            };

            //SaveButton
            var saveButton = view.FindViewById<Button>(Resource.Id.sizeAmountRowSaveButton);
            saveButton.Click += (s, e) =>
            {
                _apiClient.Update<SizeAmountPair>(sizeAmountPairs[position]);
            };

            return view;
        }
    }
}