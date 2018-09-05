using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.Domain.Tests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void ValidationTests_BusinessTrip_ExistingBusinessTrip()
        {
            var businessTrip = new BusinessTrip
            {
                Id = 1,
                DateFrom = new DateTime(2018, 04, 11),
                DateTo = new DateTime(2018, 04, 11),
                CountryId = 2,
                CityId = 3,
                SeasonId = 3,
                CurrencyId = 1
            };

            Assert.IsTrue(businessTrip.IsValid<BusinessTrip>(false));
        }

        [TestMethod]
        public void ValidationTests_BusinessTrip_NewBusinessTrip_NoDataFilled()
        {
            var businessTrip = new BusinessTrip();

            Assert.IsFalse(businessTrip.IsValid<BusinessTrip>(true));
        }

        [TestMethod]
        public void ValidationTests_BusinessTrip_NewBusinessTrip_DataFilled()
        {
            var businessTrip = new BusinessTrip
            {
                DateFrom = new DateTime(2018, 04, 11),
                DateTo = new DateTime(2018, 04, 11),
                CountryId = 2,
                CityId = 3,
                SeasonId = 3,
                CurrencyId = 1
            };

            Assert.IsTrue(businessTrip.IsValid<BusinessTrip>(true));
        }

        [TestMethod]
        public void ValidationTests_BusinessTrip_NewBusinessTrip_CityIdNotSet()
        {
            var businessTrip = new BusinessTrip
            {
                DateFrom = new DateTime(2018, 04, 11),
                DateTo = new DateTime(2018, 04, 11),
                CountryId = 2,
                SeasonId = 3,
                CurrencyId = 1
            };

            Assert.IsFalse(businessTrip.IsValid<BusinessTrip>(true));
        }

        [TestMethod]
        public void ValidationTests_BusinessTrip_NewBusinessTrip_DateToNotSet()
        {
            var businessTrip = new BusinessTrip
            {
                DateFrom = new DateTime(2018, 04, 11),
                CountryId = 2,
                CityId = 3,
                SeasonId = 3,
                CurrencyId = 1
            };

            Assert.IsFalse(businessTrip.IsValid<BusinessTrip>(true));
        }

    }
}
