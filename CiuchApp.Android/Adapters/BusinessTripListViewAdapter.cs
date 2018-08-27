using Android.App;
using Android.Views;
using Android.Widget;
using CiuchApp.Domain;
using Java.Lang;
using System.Collections.Generic;

namespace CiuchApp.Android.Adapters
{
    public class BusinessTripViewHolder : Java.Lang.Object
    {
        public TextView Country { get; set; }
        public TextView City { get; set; }
        public TextView Date { get; set; }
    }
    public class BusinessTripListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<BusinessTrip> businessTrips;

        public BusinessTripListViewAdapter(Activity activity, List<BusinessTrip> businessTrips)
        {
            this.activity = activity;
            this.businessTrips = businessTrips;

        }

        public override int Count => businessTrips.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return businessTrips[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.BusinessTripRow, parent, false);

            var CountryTextView = view.FindViewById<TextView>(Resource.Id.CountryTextView);
            var CityTextView = view.FindViewById<TextView>(Resource.Id.CityTextView);
            var DateTextView = view.FindViewById<TextView>(Resource.Id.DateTextView);

            CountryTextView.Text = businessTrips[position].Country?.Name;
            CityTextView.Text = businessTrips[position].City?.Name;
            DateTextView.Text = businessTrips[position].DateFrom.ToShortDateString();

            return view;
        }
    }
}