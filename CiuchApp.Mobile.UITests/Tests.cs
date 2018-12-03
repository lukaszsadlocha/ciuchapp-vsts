using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using CiuchApp.Mobile;

namespace CiuchApp.Mobile.UITests
{
	[TestFixture(Platform.Android)]
	//[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AllBusinessTrips_ElementExisit_NewBusinessTrip()
		{
			AppResult[] results = app.WaitForElement(c => c.Marked("Nowa podroz"));
			app.Screenshot(nameof(AllBusinessTrips_ElementExisit_NewBusinessTrip));
			Assert.IsTrue(results.Any());
		}

        [Test]
        public void AllBusinessTrips_ClickOnNewBusinessTrip_AddNewBusinessTrip()
        {
            var newBusinessTripButtonId = Resource.Id.newBusinessTrip;
            var addNewBusinessTripButtonId = Resource.Id.saveNewBusinessTrip;
            var addPiecepButtonId = Resource.Id.newClothe;

            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            app.Tap(x => x.Id(newBusinessTripButtonId));
            app.WaitForElement(c => c.Id(addNewBusinessTripButtonId));
            app.Tap(x => x.Id(addNewBusinessTripButtonId));

            app.WaitForElement(c => c.Id(addPiecepButtonId));

            app.Screenshot($"Test - Add business Trip {DateTime.Now.ToString()}");
        }
    }
}
