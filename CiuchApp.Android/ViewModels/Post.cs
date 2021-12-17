using System.Collections.Generic;

using Android.App;
using Android.Views;
using Android.Widget;

using Outcoder.UI.Xaml.Data;

namespace CiuchApp.Mobile.ViewModels
{
	public class PostListAdapter : BaseAdapter<Post>
	{
		readonly Activity activity;
		readonly List<Post> list;

		public PostListAdapter(Activity activity, List<Post> list)
		{
			this.activity = activity;
			this.list = list;
		}

		public override int Count => list.Count;

		public override long GetItemId(int position)
		{
			return position;
		}

		public override Post this[int index] => list[index];

		readonly Dictionary<View, XmlBindingApplicator> bindingsDictionary = new Dictionary<View, XmlBindingApplicator>(); 

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			View view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.ListItemRow, parent, false);

			Post item = this[position];

			XmlBindingApplicator applicator;
			if (!bindingsDictionary.TryGetValue(view, out applicator))
			{
				applicator = new XmlBindingApplicator();
			}
			else
			{
				applicator.RemoveBindings();
			}

			applicator.ApplyBindings(view, item, Resource.Layout.ListItemRow);
			//view.FindViewById<TextView>(Resource.Id.Title).Text = item.Title;
			//view.FindViewById<TextView>(Resource.Id.Description).Text = item.Description;

			return view;
		}

		protected override void Dispose(bool disposing)
		{
			foreach (var operation in bindingsDictionary.Values)
			{
				operation.RemoveBindings();
			}
			bindingsDictionary.Clear();

			base.Dispose(disposing);
		}
	}
}