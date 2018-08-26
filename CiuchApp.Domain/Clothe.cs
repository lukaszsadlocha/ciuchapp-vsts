using Android.Graphics;
using Android.Widget;
using Java.IO;
using System;

namespace CiuchApp.Domain
{
    public class Clothe
    {
        public int Id { get; set; }
        public int BusinessTripId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        //public Bitmap Image { get; set; }
        public int NumberOfSizeS { get; set; }
        public int NumberOfSizeM { get; set; }
        public int NumberOfSizeL { get; set; }

        public static string JsonKey = nameof(Clothe) + "Json";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }

        public static Clothe Deserialize(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Clothe>(json);
        }
    }
}
