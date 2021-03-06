#region File and License Information
/*
<File>
	<License Type="BSD">
		Copyright ? 2009 - 2016, Outcoder. All rights reserved.
	
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
#if __ANDROID__ || MONODROID
using Android.Views;
#else
using View = System.Object;
#endif

namespace Outcoder.UI.Xaml.Data
{
	public class ViewEventBinder<TView, TArgs, TNewValue> : IViewBinder
#if __ANDROID__ || MONODROID
		where TView : View
#endif
		where TArgs : EventArgs
	{
		readonly Action<TView, EventHandler<TArgs>> addHandler;
		readonly Action<TView, EventHandler<TArgs>> removeHandler;
		readonly Func<TView, TArgs, TNewValue> newValueFunc;

		public ViewEventBinder(
			Action<TView, EventHandler<TArgs>> addHandler,
			Action<TView, EventHandler<TArgs>> removeHandler,
			Func<TView, TArgs, TNewValue> newValueFunc)
		{
			this.addHandler = AssertNotNull(addHandler, nameof(addHandler));
			this.removeHandler = AssertNotNull(removeHandler, nameof(removeHandler));
			this.newValueFunc = AssertNotNull(newValueFunc, nameof(newValueFunc));
		}

		T AssertNotNull<T>(T value, string name)
		{
			if (value == null)
			{
				throw new ArgumentNullException(name);
			}

			return value;
		}

		public Action BindView(PropertyBinding propertyBinding, object dataContext)
		{
			EventHandler<TArgs> handler =
				(sender, args) =>
				{
					ViewValueChangedHandler.HandleViewValueChanged(propertyBinding, newValueFunc, dataContext, args);
				};

			addHandler((TView)propertyBinding.View, handler);

			Action removeAction = () => { removeHandler((TView)propertyBinding.View, handler); };
			return removeAction;
		}
	}
}