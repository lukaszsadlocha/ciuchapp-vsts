using System;

namespace CiuchApp.Domain
{
    public class BusinessTrip
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Country Country { get; set; }
        public string CountryId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public Season Season { get; set; }
        public int SeasonId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }

        public static string JsonKey = nameof(BusinessTrip)+"Json";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static BusinessTrip Deserialize(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BusinessTrip>(json);
        }



    }
}
