using System;
using System.Collections.Generic;
using System.Text;

namespace CiuchApp.Domain
{
    public class CacheContext
    {
        public IList<BusinessTrip> BusinessTrips { get; set; }

        public IList<Color>             Colors { get; set; }
        public IList<TopCategory>       TopCategories { get; set; }
        public IList<MainCategory>      MainCategories { get; set; }
        public IList<Group>             Groups { get; set; }
        public IList<Component>         Components { get; set; }
        public IList<CountryOfOrigin>   CountryOfOrigin { get; set; }
        public IList<Supplier>          Suppliers { get; set; }
        public IList<Size>              Sizes { get; set; }
        public IList<CodeCn>            CodeCns { get; set; }
        public IList<Set>               Sets { get; set; }
        public IList<ColorName>         ColorNames { get; set; }
        public IList<SizeAmountPair>    SizeAmountPairs { get; set; }

        public IList<Country>           Countries { get; set; }
        public IList<City>              Cities { get; set; }
        public IList<Season>            Seasons { get; set; }
        public IList<Currency>          Currencies { get; set; }

        public static string JsonKey => nameof(CacheContext) + "Json";

        public string Serialize()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        public static CacheContext Deserialize(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CacheContext>(json);
        }

        public Piece NewPiece { get; set; }
        public SizeAmountPair NewSizeAmount { get; set; }
    }
}
