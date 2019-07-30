#region File and License Information
/*
<File>
	<License Type="BSD">
		Copyright � 2009 - 2016, Outcoder. All rights reserved.
	
		This file is part of Calcium (http://calciumsdk.net).

		Redistribution and use in source and binary forms, with or without
		modification, are permitted provided that the following conditions are met:
			* Redistributions of source code must retain the above copyright
			  notice, this list of conditions and the following disclaimer.
			* Redistributions in binary form must reproduce the above copyright
			  notice, this list of conditions and the following disclaimer in the
			  documentation and/or other materials provided with the distribution.
			* Neither the name of the <organization> nor the
			  names of its contributors may be used to endorse or promote products
			  derived from this software without specific prior written permission.

		THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
		ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
		WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
		DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
		DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
		(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
		LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
		ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
		(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
		SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
	</License>
	<Owner Name="Daniel Vaughan" Email="danielvaughan@outcoder.com" />
	<CreationDate>$CreationDate$</CreationDate>
</File>
*/
#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

#if __ANDROID__ || MONODROID
using Android.Widget;
#endif

namespace Outcoder.UI.Xaml.Data
{
	public class ViewBinderRegistry
	{
		public bool RemoveViewBinder(Type viewType, string propertyName)
		{
			string key = MakeDictionaryKey(viewType, propertyName);
			return binderDictionary.Remove(key);
		}

		public bool TryGetViewBinder(Type viewType, string propertyName, out IViewBinder viewBinder)
		{
			string key = MakeDictionaryKey(viewType, propertyName);

			if (binderDictionary.TryGetValue(key, out viewBinder))
			{
					return true;
			}

			return false;
		}

		static string MakeDictionaryKey(Type viewType, string propertyName)
		{
			return viewType.AssemblyQualifiedName + "." + propertyName;
		}

		public void SetViewBinder<TView>(string propertyName, IViewBinder viewBinder)
		{
			string key = typeof(TView).AssemblyQualifiedName + "." + propertyName;
			binderDictionary[key] = viewBinder;
		}

		public void SetViewBinder(Type viewType, string propertyName, IViewBinder viewBinder)
		{
			string key = MakeDictionaryKey(viewType, propertyName);
			binderDictionary[key] = viewBinder;
		}

		readonly Dictionary<string, IViewBinder> binderDictionary
			= new Dictionary<string, IViewBinder>
			{
#if __ANDROID__ || MONODROID
				{MakeDictionaryKey(typeof(CalendarView), nameof(CalendarView.Date)), new ViewEventBinder<CalendarView, CalendarView.DateChangeEventArgs, DateTime>(
					(view, h) => view.DateChange += h, (view, h) => view.DateChange -= h, (view, args) => new DateTime(args.Year, args.Month, args.DayOfMonth))},
				{MakeDictionaryKey(typeof(CheckBox), nameof(CheckBox.Checked)), new ViewEventBinder<CheckBox, CheckBox.CheckedChangeEventArgs, bool>(
					(view, h) => view.CheckedChange += h, (view, h) => view.CheckedChange -= h, (view, args) => args.IsChecked)},
				{MakeDictionaryKey(typeof(RadioButton), nameof(RadioButton.Checked)), new ViewEventBinder<RadioButton, RadioButton.CheckedChangeEventArgs, bool>(
					(view, h) => view.CheckedChange += h, (view, h) => view.CheckedChange -= h, (view, args) => args.IsChecked)},
				{MakeDictionaryKey(typeof(RatingBar), nameof(RatingBar.Rating)), new ViewEventBinder<RatingBar, RatingBar.RatingBarChangeEventArgs, float>(
					(view, h) => view.RatingBarChange += h, (view, h) => view.RatingBarChange -= h, (view, args) => args.Rating)},
				{MakeDictionaryKey(typeof(SearchView), nameof(SearchView.Query)), new ViewEventBinder<SearchView, SearchView.QueryTextChangeEventArgs, string>(
					(view, h) => view.QueryTextChange += h, (view, h) => view.QueryTextChange -= h, (view, args) => args.NewText)},
				{MakeDictionaryKey(typeof(Switch), nameof(Switch.Checked)), new ViewEventBinder<Switch, Switch.CheckedChangeEventArgs, bool>(
					(view, h) => view.CheckedChange += h, (view, h) => view.CheckedChange -= h, (view, args) => args.IsChecked)},
				{MakeDictionaryKey(typeof(TimePicker), nameof(TimePicker.Minute)), new ViewEventBinder<TimePicker, TimePicker.TimeChangedEventArgs, int>(
					(view, h) => view.TimeChanged += h, (view, h) => view.TimeChanged -= h, (view, args) => args.Minute)},
				{MakeDictionaryKey(typeof(TimePicker), nameof(TimePicker.Hour)), new ViewEventBinder<TimePicker, TimePicker.TimeChangedEventArgs, int>(
					(view, h) => view.TimeChanged += h, (view, h) => view.TimeChanged -= h, (view, args) => args.HourOfDay)},
				{MakeDictionaryKey(typeof(EditText), nameof(EditText.Text)), new ViewEventBinder<EditText, Android.Text.TextChangedEventArgs, string>(
					(view, h) => view.TextChanged += h, (view, h) => view.TextChanged -= h, (view, args) => args.Text.ToString())},
				{MakeDictionaryKey(typeof(ToggleButton), nameof(ToggleButton.Text)), new ViewEventBinder<ToggleButton, CompoundButton.CheckedChangeEventArgs, bool>(
					(view, h) => view.CheckedChange += h, (view, h) => view.CheckedChange -= h, (view, args) => args.IsChecked)},
				{MakeDictionaryKey(typeof(SeekBar), nameof(SeekBar.Progress)), new ViewEventBinder<SeekBar, SeekBar.ProgressChangedEventArgs, int>(
					(view, h) => view.ProgressChanged += h, (view, h) => view.ProgressChanged -= h, (view, args) => args.Progress)},
#endif
			};
	}
}