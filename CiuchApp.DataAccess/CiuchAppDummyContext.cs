using System;
using System.Collections.Generic;
using System.Linq;

using CiuchApp.Domain;

namespace CiuchApp.DataAccess
{
    public class CiuchAppDummyContext
    {
        private List<Piece> clothes = new List<Piece>() {
                new Piece {
                    Id = 1,
                   BusinessTripId=1,
                    Name = "Niebieskie spodnie"
                    },

                new Piece {
                    Id = 2,
                    BusinessTripId=2,
                    Name = "Żółty Sweterek"},

                new Piece {
                    Id = 3,
                     BusinessTripId=3,
                    Name = "Bluza z kapturem"},

                new Piece {
                    Id = 4,
                    BusinessTripId =2,
                    Name = "Białe buty"},

                new Piece {
                    Id = 5,
                    BusinessTripId=2,
                    Name = "Skarpetki czarne"},
            };

        private readonly List<BusinessTrip> businessTrips =new List<BusinessTrip>() {
                new BusinessTrip { Id = 1,  DateFrom = new DateTime(2018,04,11) },
                new BusinessTrip { Id = 2,  DateFrom = new DateTime(2018,05,18) },
                new BusinessTrip { Id = 3,  DateFrom = new DateTime(2018,07,02) }
            };

        public CiuchAppDummyContext()
        {
            //Upload demo images to Android Emulator


        }

        public List<BusinessTrip> GetBusinessTrips()
        {
            return businessTrips;
        }

        public List<Piece> GetPieces()
        {
            return clothes;
        }


        public List<Piece> GetClothesByBusinessTripId(int businessTrip)
        {
            return clothes.FindAll(x => x.BusinessTripId == businessTrip).ToList();
        }
    }
}
