using Android.App;
using Android.Views;
using Android.Widget;
using CiuchApp.Domain;
using Java.Lang;
using System.Collections.Generic;

namespace CiuchApp.Android.Adapters
{
    public class ClotheViewHolder : Java.Lang.Object
    {
        public TextView Country { get; set; }
        public TextView City { get; set; }
        public TextView Date { get; set; }
    }
    public class ClotheListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<Clothe> clothe;

        public ClotheListViewAdapter(Activity activity, List<Clothe> clothe)
        {
            this.activity = activity;
            this.clothe = clothe;

        }

        public override int Count => clothe.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return clothe[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ClotheRow, parent, false);

            var NameTextView = view.FindViewById<TextView>(Resource.Id.clotheRowName);
            var ImageView =  view.FindViewById<ImageView>(Resource.Id.clotheRowImage);

            NameTextView.Text = clothe[position].Name;
            //ImageView.Text = clothe[position].Image;

            return view;
        }
    }
}