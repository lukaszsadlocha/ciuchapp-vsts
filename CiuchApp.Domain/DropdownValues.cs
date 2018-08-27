﻿using System.Collections.Generic;

namespace CiuchApp.Domain
{
    public abstract class DropDownValueBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public abstract class PieceDropdownValueBase : DropDownValueBase
    {
        public List<Piece> Pieces { get; set; }
    }

    public abstract class BusinessTripDropdownValueBase : DropDownValueBase
    {
        public List<BusinessTrip> BusinessTrips { get; set; }
    }

    // Piece Values

    public class Color : PieceDropdownValueBase { }
    public class MainCategory : PieceDropdownValueBase { }
    public class Group : PieceDropdownValueBase { }
    public class Component : PieceDropdownValueBase { }
    public class CountryOfOrigin : PieceDropdownValueBase { }
    public class Supplier : PieceDropdownValueBase { }
    public class Size : PieceDropdownValueBase { }
    public class CodeCn : PieceDropdownValueBase { }
    public class Set : PieceDropdownValueBase { }
    public class ColorName : PieceDropdownValueBase { }

    //BusinessTrip Values

    public class Country : BusinessTripDropdownValueBase { }
    public class City : BusinessTripDropdownValueBase { }
    public class Season : BusinessTripDropdownValueBase { }
    public class Currency : BusinessTripDropdownValueBase { }






}