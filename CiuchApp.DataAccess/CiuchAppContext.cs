using System;
using System.Collections.Generic;
using System.Linq;

using CiuchApp.Domain;

namespace CiuchApp.DataAccess
{
    public class CiuchAppContext
    {
        private List<Clothe> clothes = new List<Clothe>() {
                new Clothe {
                    Id = 1,
                   BusinessTripId=1,
                    Name = "Niebieskie spodnie",
                    Description =  "Czinosy od Levis'a",
                    NumberOfSizeS = 12,
                    NumberOfSizeM = 20,
                    NumberOfSizeL = 25 },

                new Clothe {
                    Id = 2,
                    BusinessTripId=2,
                    Name = "Żółty Sweterek",
                    Description =  "Wygląda jak z filmu'a",
                    NumberOfSizeS = 40,
                    NumberOfSizeM = 120,
                    NumberOfSizeL = 60 },

                new Clothe {
                    Id = 3,
                     BusinessTripId=3,
                    Name = "Bluza z kapturem",
                    Description =  "Idealna na koncert O.S.T.R",
                    NumberOfSizeS = 10,
                    NumberOfSizeM = 40,
                    NumberOfSizeL = 70 },

                new Clothe {
                    Id = 4,
                    BusinessTripId =2,
                    Name = "Białe buty",
                    Description =  "Najlepsze na lato",
                    NumberOfSizeS = 42,
                    NumberOfSizeM = 70,
                    NumberOfSizeL = 100 },

                new Clothe {
                    Id = 5,
                    BusinessTripId=2,
                    Name = "Skarpetki czarne",
                    Description =  "na każdą okazje",
                    NumberOfSizeS = 14,
                    NumberOfSizeM = 80,
                    NumberOfSizeL = 55 },

            };

        private List<BusinessTrip> businessTrips =new List<BusinessTrip>() {
                new BusinessTrip { Id = 1, Country = "Francja", City = "Paryż", Date = "14 Marca 2018" },
                new BusinessTrip { Id = 2, Country = "Polska", City = "Wólka", Date = "11 Maja 2018" },
                new BusinessTrip { Id = 3, Country = "Anglia", City = "London", Date = "7 Czerwca 2018" }
            };

        public CiuchAppContext()
        {
            //Upload demo images to Android Emulator


        }

        public List<BusinessTrip> GetBusinessTrips()
        {
            return businessTrips;
        }

        public List<Clothe> GetClothes()
        {
            return clothes;
        }


        public List<Clothe> GetClothesByBusinessTripId(int businessTrip)
        {
            return clothes.FindAll(x => x.BusinessTripId == businessTrip).ToList();
        }


    }
}
