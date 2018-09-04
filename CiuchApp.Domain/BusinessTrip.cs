using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Reflection;

namespace CiuchApp.Domain
{
    public class BusinessTrip : CiuchAppModelBase
    {
        [DisplayName("#")]
        //[CiuchAppTranslatable]
        public int Id { get; set; }

        [DisplayName("Data od")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateFrom { get; set; }

        [DisplayName("Data do")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateTo { get; set; }
        [DisplayName("Kraj")]
        public virtual Country Country { get; set; }
        public int CountryId { get; set; }
        [DisplayName("Miasto")]
        public virtual City City { get; set; }
        public int CityId { get; set; }
        [DisplayName("Sezon")]
        public virtual Season Season { get; set; }
        public int SeasonId { get; set; }
        [DisplayName("Waluta")]
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
