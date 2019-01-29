using Android.App;
using Android.Views;
using Android.Widget;
using CiuchApp.Domain;
using CiuchApp.Mobile.Helpers;
using Java.Lang;
using System.Collections.Generic;

namespace CiuchApp.Mobile.Adapters
{
    public class ClotheViewHolder : Java.Lang.Object
    {
        public TextView Country { get; set; }
        public TextView City { get; set; }
        public TextView Date { get; set; }
    }
    public class PieceListViewAdapter : BaseAdapter
    {
        private Activity activity;
        private List<Piece> pieces;
        private readonly IEnvironmentHelper environmentHelper;

        public PieceListViewAdapter(Activity activity, List<Piece> pieces, IEnvironmentHelper environmentHelper)
        {
            this.activity = activity;
            this.pieces = pieces;
            this.environmentHelper = environmentHelper;
        }

        public override int Count => pieces.Count;

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return pieces[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.PieceRow, parent, false);
            var currentPiece = pieces[position];
            view.FindViewById<TextView>(Resource.Id.pieceRowName).Text = currentPiece.Name;

            if (!string.IsNullOrEmpty(currentPiece.ImageName))
            {
                string imageParh = environmentHelper.GetImageFullPath(currentPiece.ImageName);
                var image = imageParh.LoadAndResizeBitmap(100, 100);

                view.FindViewById<ImageView>(Resource.Id.pieceRowImage).SetImageBitmap(image);
            }

            return view;
        }
    }
}