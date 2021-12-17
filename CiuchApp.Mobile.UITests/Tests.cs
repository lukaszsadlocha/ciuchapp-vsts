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
        private readonly Platform platform;

        private readonly int newBusinessTripButtonId = 11;//Resource.Id.newBusinessTrip;
        private readonly int addNewBusinessTripButtonId = 11;//Resource.Id.saveNewBusinessTrip;
        private readonly int addPiecepButtonId = 11;//Resource.Id.;
        private readonly int countrySpinnerId = Resource.Id.countrySpinner;
        private readonly int citySpinnerId = Resource.Id.citySpinner;
        private readonly int currencySpinnerId = Resource.Id.currencySpinner;
        private readonly int pieceImage = Resource.Id.PieceImage;

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
        public void AllBusinessTrips_ClickOnNewBusinessTrip_AddNewSpainBusinessTrip()
        {
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            MoveTo_NewBusinessTrip();
            NewBusinessTrip_ChangeCurrencyTo("EURO");
            NewBusinessTrip_ChangeCountryTo("Hiszpania");
            NewBusinessTrip_ChangeCityTo("Madryt");

            app.Tap(x => x.Id(addNewBusinessTripButtonId));

            app.WaitForElement(c => c.Id(addPiecepButtonId));

            app.Screenshot($"Test - Add business Trip {DateTime.Now.ToString()}");
        }

        [Test]
        public void AllBusinessTrips_ClickOnNewBusinessTrip_GoBack()
        {
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            MoveTo_NewBusinessTrip();

            app.Back();
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));
        }

        [Test]
        public void AllBusinessTrips_ClickOnNewBusinessTrip_ChangeCurrency_GoBack()
        {
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            MoveTo_NewBusinessTrip();
            NewBusinessTrip_ChangeCurrencyTo("EURO");
            app.Back();

            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            app.Screenshot($"Test - Add business Trip {DateTime.Now.ToString()}");
        }

        [Test]
        public void AllBusinessTrips_OpenSpainBusinessTrip_NewPiece()
        {
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            app.Tap(x => x.Text("Hiszpania"));

            app.Tap(x => x.Id(addPiecepButtonId));

            app.Repl();

            app.Back();
        }

        [Test]
        public void AllBusinessTrips_OpenSpainBusinessTrip_EditPiece()
        {
            app.WaitForElement(c => c.Id(newBusinessTripButtonId));

            app.Tap(x => x.Text("Hiszpania"));

            app.WaitForElement(c => c.Id(addPiecepButtonId));

            app.Tap(x => x.Text("test 1"));

            app.WaitForElement(c => c.Id(pieceImage));

            app.Back();
        }

        private void MoveTo_NewBusinessTrip()
        {
            app.Tap(x => x.Id(newBusinessTripButtonId));
            app.WaitForElement(c => c.Id(addNewBusinessTripButtonId));
        }

        private void NewBusinessTrip_ChangeCurrencyTo(string v)
        {
            app.Tap(x => x.Id(currencySpinnerId));
            app.Tap(x => x.Text(v));
            app.WaitForElement(c => c.Id(addNewBusinessTripButtonId));
        }


        private void NewBusinessTrip_ChangeCityTo(string v)
        {
            app.Tap(x => x.Id(citySpinnerId));
            app.Tap(x => x.Text(v));
            app.WaitForElement(c => c.Id(addNewBusinessTripButtonId));
        }

        private void NewBusinessTrip_ChangeCountryTo(string v)
        {
            app.Tap(x => x.Id(countrySpinnerId));
            app.Tap(x => x.Text(v));
            app.WaitForElement(c => c.Id(addNewBusinessTripButtonId));
        }
    }
}
