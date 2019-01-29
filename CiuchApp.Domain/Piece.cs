using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CiuchApp.Domain
{
    public class Piece : CiuchAppModelBase
    {
        #region Domain Properties

        [Required]
        [DisplayName("Nazwa")]
        public string Name { get; set; } //Name from Producer

        [JsonIgnore]
        [DisplayName("Wyjazd")]
        public BusinessTrip BusinessTrip { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int BusinessTripId { get; set; }

        [DisplayName("Kolor")]
        public Color Color { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int ColorId { get; set; }

        [DisplayName("Typ produktu")]
        public TopCategory TopCategory { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int TopCategoryId { get; set; }

        [DisplayName("Kategoria główna")]
        public MainCategory MainCategory { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int MainCategoryId { get; set; }

        [DisplayName("Grupa")]
        public Group Group { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int GroupId { get; set; }

        [DisplayName("Skład")]
        public Component Component { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int ComponentId { get; set; }

        [DisplayName("Kraj pochodzenia")]
        public CountryOfOrigin CountryOfOrigin { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int CountryOfOriginId { get; set; }

        [Required]
        [DisplayName("Cena zakupu")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a correct value")]
        public double BuyPrice { get; set; }

        [Required]
        [DisplayName("Cena sprzedaży")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a correct value")]
        public double SellPrice { get; set; }

        [DisplayName("Dostawca")]
        public Supplier Supplier { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int SupplierId { get; set; }
        
        [DisplayName("Data zamówienia")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [DisplayName("Data wysyłki")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedDateOfShipment { get; set; }

        [DisplayName("Data dostawy")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EstimatedTimeOfDelivery { get; set; }

        [DisplayName("Kod CN")]
        public CodeCn CodeCn { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int CodeCnId { get; set; }

        [DisplayName("Set")]
        public Set Set { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int SetId { get; set; }

        [DisplayName("Nazwa koloru")]
        public ColorName ColorName { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a correct value")]
        public int ColorNameId { get; set; }

        public string ImageName { get; set; } 

        public virtual ICollection<SizeAmountPair> SizeAmountPairs { get; set; }

        #endregion

        public static string JsonKey => nameof(Piece) + "Json";

        public static string JsonListKey => nameof(Piece) + "ListJson";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static string SerializeList(List<Piece> pieces)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(pieces);
        }

        public static Piece Deserialize(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Piece>(json);
        }

        public static List<Piece> DeserializeList(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;

            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Piece>>(json);
        }

    }
}
