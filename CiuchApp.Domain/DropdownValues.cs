using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace CiuchApp.Domain
{
    [DebuggerDisplay("Name={Name} Id={Id}")]
    public abstract class DropDownValueBase : CiuchAppBaseModel
    {
        [Required]
        public string Name { get; set; }
    }

    public abstract class PieceDropdownValueBase : DropDownValueBase
    {
        [JsonIgnore]
        public virtual List<Piece> Pieces { get; set; }
    }

    public abstract class BusinessTripDropdownValueBase : DropDownValueBase
    {
        [JsonIgnore]
        public virtual List<BusinessTrip> BusinessTrips { get; set; }
    }

    // Piece Values

    public class Color : PieceDropdownValueBase { }

    public class TopCategory : PieceDropdownValueBase
    {
        public List<MainCategory> MainCategories { get; set; }
    }

    public class MainCategory : PieceDropdownValueBase
    {
        public int TopCategoryId { get; set; }
        [JsonIgnore]
        public TopCategory TopCategory { get; set; }
        public List<Group> Groups { get; set; }
    }
    public class Group : PieceDropdownValueBase {
        public string GroupCode { get; set; }
        public string CnCode { get; set; }
        public int MainCategoryId { get; set; }

        [JsonIgnore]
        public MainCategory MainCategory { get; set; }
    }
    public class Component : PieceDropdownValueBase { }
    public class CountryOfOrigin : PieceDropdownValueBase {
        public string CountryOfOriginCode { get; set; }
    }
    public class Supplier : PieceDropdownValueBase { }
    public class Size : PieceDropdownValueBase { }
    public class CodeCn : PieceDropdownValueBase { }
    public class Set : PieceDropdownValueBase { }
    public class ColorName : PieceDropdownValueBase { }

    public class PieceType : PieceDropdownValueBase { }

    //BusinessTrip Values

    public class Country : BusinessTripDropdownValueBase {
        public List<City> Cities { get; set; }
    }
    public class City : BusinessTripDropdownValueBase {
        public int CountryId { get; set; }

        [JsonIgnore]
        public Country Country { get; set; }
    }
    public class Season : BusinessTripDropdownValueBase { }
    public class Currency : BusinessTripDropdownValueBase { }






}
