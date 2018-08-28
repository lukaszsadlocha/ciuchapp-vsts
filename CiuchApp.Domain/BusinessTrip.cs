using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CiuchApp.Domain
{
    public class BusinessTrip
    {
        [DisplayName("Numer")]
//        [CiuchAppTranslatable]
        public int Id { get; set; }

        [DisplayName("Data od")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateFrom { get; set; }

        [DisplayName("Data do")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTo { get; set; }
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        [DisplayName("Miasto")]
        public virtual City City { get; set; }
        public int CityId { get; set; }
        public virtual Season Season { get; set; }
        public int SeasonId { get; set; }
        public virtual Currency Currency { get; set; }
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
