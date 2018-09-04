using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.Domain.Tests
{
    [TestClass]
    public class DomainTests
    {
        [TestMethod]
        public void BusinessTrips_ToKeyValuePairs()
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

            //var result = businessTrip.ToKeyValuePairs();
        }
    }
}
