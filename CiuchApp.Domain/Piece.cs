using Android.Graphics;
using Android.Widget;
using Java.IO;
using System;

namespace CiuchApp.Domain
{
    public class Piece : CiuchAppModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; } //Name from Producer
        public BusinessTrip BusinessTrip { get; set; }
        public int BusinessTripId { get; set; }
        public Color Color { get; set; }
        public int ColorId { get; set; }
        public MainCategory MainCategory { get; set; }
        public int MainCategoryId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public Component Component { get; set; }
        public int ComponentsId { get; set; }
        public CountryOfOrigin CountryOfOrigin { get; set; }
        public int CountryOfOriginId { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }
        public Supplier Supplier { get; set; }
        public int SupplierId { get; set; }
        public Size Size { get; set; }
        public int SizeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime EstimatedDateOfShipment { get; set; }
        public DateTime EstimatedTimeOfDelivery { get; set; }
        public int Amount { get; set; }
        public CodeCn CodeCn { get; set; }
        public int CodeCnId { get; set; }
        public Set Set { get; set; }
        public int SetId { get; set; }
        public ColorName ColorName { get; set; }
        public int ColorNameId { get; set; }
        public string ImagePath { get; set; }

        public static string JsonKey = nameof(Piece) + "Json";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Piece Deserialize(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Piece>(json);
        }
    }
}
