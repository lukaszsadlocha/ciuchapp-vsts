using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CiuchApp.Domain.Tests
{
    [TestClass]
    public class SerializationAndDeserializationTests
    {
        [TestMethod]
        public void BusinessTrip_Serialize()
        {
            var businessTrip = new BusinessTrip
            {
                Id = 1,
                DateFrom = new DateTime(2018, 04, 11),
                DateTo = new DateTime(2018, 04, 14),
                CountryId = 2,
                CityId = 3,
                SeasonId = 3,
                CurrencyId = 1
            };

            var result = businessTrip.Serialize();

            result.Should().NotBeNullOrEmpty();
            result.Should().Be("{\"Id\":1," +
                "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                "\"DateTo\":\"2018-04-14T00:00:00\"," +
                "\"Country\":null," +
                "\"CountryId\":2," +
                "\"City\":null," +
                "\"CityId\":3," +
                "\"Season\":null," +
                "\"SeasonId\":3," +
                "\"Currency\":null," +
                "\"CurrencyId\":1}");
        }

        [TestMethod]
        public void BusinessTrip_Deserialize()
        {
            var json = 
                "{\"Id\":1," +
                "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                "\"DateTo\":\"2018-04-14T00:00:00\"," +
                "\"Country\":null," +
                "\"CountryId\":2," +
                "\"City\":null," +
                "\"CityId\":3," +
                "\"Season\":null," +
                "\"SeasonId\":3," +
                "\"Currency\":null," +
                "\"CurrencyId\":1}";

            var result = BusinessTrip.Deserialize(json);

            result.Should().NotBeNull();
            result.Id.Should().Be(1);
            result.DateTo.Should().Be(new DateTime(2018,04,14));
            result.City.Should().BeNull();
            result.CityId.Should().Be(3);
        }

        [TestMethod]
        public void BusinessTrip_SerializeList()
        {
            var list = new List<BusinessTrip>
            {
                new BusinessTrip
                {
                    Id = 1,
                    DateFrom = new DateTime(2018, 04, 11),
                    DateTo = new DateTime(2018, 04, 14),
                    CountryId = 2,
                    CityId = 3,
                    SeasonId = 3,
                    CurrencyId = 1
                },
                new BusinessTrip
                {
                    Id = 2,
                    DateFrom = new DateTime(2018, 04, 11),
                    DateTo = new DateTime(2018, 04, 14),
                    CountryId = 2,
                    CityId = 3,
                    SeasonId = 3,
                    CurrencyId = 1
                }
            };

            var result = BusinessTrip.SerializeList(list);

            result.Should().NotBeNull();
            result.Should().Be(
                "[" +
                   "{" +
                       "\"Id\":1," +
                       "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                       "\"DateTo\":\"2018-04-14T00:00:00\"," +
                       "\"Country\":null," +
                       "\"CountryId\":2," +
                       "\"City\":null," +
                       "\"CityId\":3," +
                       "\"Season\":null," +
                       "\"SeasonId\":3," +
                       "\"Currency\":null," +
                       "\"CurrencyId\":1" +
                   "}," +
                   "{" +
                       "\"Id\":2," +
                       "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                       "\"DateTo\":\"2018-04-14T00:00:00\"," +
                       "\"Country\":null," +
                       "\"CountryId\":2," +
                       "\"City\":null," +
                       "\"CityId\":3," +
                       "\"Season\":null," +
                       "\"SeasonId\":3," +
                       "\"Currency\":null," +
                       "\"CurrencyId\":1" +
                   "}" +
                "]");
        }

        [TestMethod]
        public void BusinessTrip_SerializeList_ListIsNull()
        {
            List<BusinessTrip> list = null;

            var result = BusinessTrip.SerializeList(list);

            result.Should().NotBeNull();
            result.Should().Be("null");

        }

        [TestMethod]
        public void BusinessTrip_DeserializeList()
        {
            var json =
                "[" +
                   "{" +
                       "\"Id\":1," +
                       "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                       "\"DateTo\":\"2018-04-14T00:00:00\"," +
                       "\"Country\":null," +
                       "\"CountryId\":2," +
                       "\"City\":null," +
                       "\"CityId\":3," +
                       "\"Season\":null," +
                       "\"SeasonId\":3," +
                       "\"Currency\":null," +
                       "\"CurrencyId\":1" +
                   "}," +
                   "{" +
                       "\"Id\":2," +
                       "\"DateFrom\":\"2018-04-11T00:00:00\"," +
                       "\"DateTo\":\"2018-04-14T00:00:00\"," +
                       "\"Country\":null," +
                       "\"CountryId\":2," +
                       "\"City\":null," +
                       "\"CityId\":3," +
                       "\"Season\":null," +
                       "\"SeasonId\":3," +
                       "\"Currency\":null," +
                       "\"CurrencyId\":1" +
                   "}" +
                "]";

            var result = BusinessTrip.DeserializeList(json);

            result.Should().NotBeNull();
            result.Should().HaveCount(2);
            result.First().Id.Should().Be(1);
            result.Last().Id.Should().Be(2);
            result.Last().SeasonId.Should().Be(3);
                
        }

    }
}
