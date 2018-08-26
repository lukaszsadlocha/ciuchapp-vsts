using System;

namespace CiuchApp.Domain
{
    public class BusinessTrip
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Date { get; set; }

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
