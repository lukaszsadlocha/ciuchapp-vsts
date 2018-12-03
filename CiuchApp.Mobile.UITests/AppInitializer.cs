using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CiuchApp.Mobile.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{
				return ConfigureApp
                    .Android
                    .ApkFile("../../../CiuchApp.Android/bin/Release/CiuchyAndroid.CiuchyAndroid.apk")
                    .EnableLocalScreenshots()
                    .StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}