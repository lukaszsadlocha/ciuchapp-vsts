using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CiuchApp.Domain;
using CiuchApp.DataAccess.AspNetIdentity;

namespace CiuchApp.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Piece>().
                HasOne(x => x.Group).
                WithMany(x => x.Pieces).
                OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Piece>().
                HasOne(x => x.TopCategory).
                WithMany(x => x.Pieces).
                OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Piece>().
                HasOne(x => x.MainCategory).
                WithMany(x => x.Pieces).
                OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<MainCategory>().
            //    HasOne(x => x.TopCategory).
            //    WithMany(x => x.MainCategories).
            //    OnDelete(DeleteBehavior.Restrict);


            SeedData(builder);

        }

        private void SeedData(ModelBuilder builder)
        {
            

            #region Piece Dropdown values
            ////////////////////////////////////////
            builder.Entity<Color>().HasData(
                    new { Id = 1, Name = "KLAM212" },
                    new { Id = 2, Name = "OWTR20" },
                    new { Id = 3, Name = "BLEW32" },
                    new { Id = 4, Name = "KKE2111" }
                    );
            builder.Entity<TopCategory>().HasData(
                new { Id = 1, Name = "Odzież" },
                new { Id = 2, Name = "Obuwie" },
                new { Id = 3, Name = "Akcesoria" }
                );


            #region MainCategory Values
            builder.Entity<MainCategory>().HasData(
                new { Id = 1, TopCategoryId = 1, Name = "Bielizna" },
                new { Id = 2, TopCategoryId = 1, Name = "Bluzki" },
                new { Id = 3, TopCategoryId = 1, Name = "Bluzy" },
                new { Id = 4, TopCategoryId = 1, Name = "Jeansy" },
                new { Id = 5, TopCategoryId = 1, Name = "Kombinezony" },
                new { Id = 6, TopCategoryId = 1, Name = "Komplety i dresy" },
                new { Id = 7, TopCategoryId = 1, Name = "Koszule" },
                new { Id = 8, TopCategoryId = 1, Name = "Kurtki i płaszcze" },
                new { Id = 9, TopCategoryId = 1, Name = "Marynarki i garnitury" },
                new { Id = 10, TopCategoryId = 1, Name = "Materiały" },
                new { Id = 11, TopCategoryId = 1, Name = "Odzież niemowlęca" },
                new { Id = 12, TopCategoryId = 1, Name = "Snowboard" },
                new { Id = 13, TopCategoryId = 1, Name = "Spódnice" },
                new { Id = 14, TopCategoryId = 1, Name = "Spodnie" },
                new { Id = 15, TopCategoryId = 1, Name = "Spodnie i legginsy" },
                new { Id = 16, TopCategoryId = 1, Name = "Stroje kąpielowe" },
                new { Id = 17, TopCategoryId = 1, Name = "Sukienki i tuniki" },
                new { Id = 18, TopCategoryId = 1, Name = "Swetry" },
                new { Id = 19, TopCategoryId = 1, Name = "Szorty" },
                new { Id = 20, TopCategoryId = 1, Name = "T-shirty i polo" },
                new { Id = 21, TopCategoryId = 1, Name = "Topy" },
                new { Id = 22, TopCategoryId = 1, Name = "Żakiety" },
                new { Id = 23, TopCategoryId = 2, Name = "Baleriny" },
                new { Id = 24, TopCategoryId = 2, Name = "Buty wysokie" },
                new { Id = 25, TopCategoryId = 2, Name = "Dziecko" },
                new { Id = 26, TopCategoryId = 2, Name = "Kalosze" },
                new { Id = 27, TopCategoryId = 2, Name = "Klapki i sandały" },
                new { Id = 28, TopCategoryId = 2, Name = "Kozaki i botki" },
                new { Id = 29, TopCategoryId = 2, Name = "Mokasyny i półbuty" },
                new { Id = 30, TopCategoryId = 2, Name = "Outdoor" },
                new { Id = 31, TopCategoryId = 2, Name = "Sportowe i lifestyle" },
                new { Id = 32, TopCategoryId = 2, Name = "Szpilki" },
                new { Id = 33, TopCategoryId = 2, Name = "Trampki i tenisówki" },
                new { Id = 34, TopCategoryId = 2, Name = "Zimowe" },
                new { Id = 35, TopCategoryId = 3, Name = "Bielizna" },
                new { Id = 36, TopCategoryId = 3, Name = "Biżuteria" },
                new { Id = 37, TopCategoryId = 3, Name = "Czapki i kapelusze" },
                new { Id = 38, TopCategoryId = 3, Name = "Gadżety i akcesoria" },
                new { Id = 39, TopCategoryId = 3, Name = "Kosmetyki" },
                new { Id = 40, TopCategoryId = 3, Name = "Krawaty i muchy" },
                new { Id = 41, TopCategoryId = 3, Name = "Książki i albumy" },
                new { Id = 42, TopCategoryId = 3, Name = "Okulary" },
                new { Id = 43, TopCategoryId = 3, Name = "Parasole" },
                new { Id = 44, TopCategoryId = 3, Name = "Paski" },
                new { Id = 45, TopCategoryId = 3, Name = "Pielęgnacja obuwia" },
                new { Id = 46, TopCategoryId = 3, Name = "Plecaki" },
                new { Id = 47, TopCategoryId = 3, Name = "Portfele" },
                new { Id = 48, TopCategoryId = 3, Name = "Rajstopy i skarpetki" },
                new { Id = 49, TopCategoryId = 3, Name = "Rękawiczki" },
                new { Id = 50, TopCategoryId = 3, Name = "Rowery" },
                new { Id = 51, TopCategoryId = 3, Name = "Skarpety" },
                new { Id = 52, TopCategoryId = 3, Name = "Słuchawki" },
                new { Id = 53, TopCategoryId = 3, Name = "Snowboard" },
                new { Id = 54, TopCategoryId = 3, Name = "Szaliki i chusty" },
                new { Id = 55, TopCategoryId = 3, Name = "Torby i walizki" },
                new { Id = 56, TopCategoryId = 3, Name = "Torebki" },
                new { Id = 57, TopCategoryId = 3, Name = "Zegarki" }
                );
            #endregion

            builder.Entity<Group>().HasData(
            #region Values
                new { Id = 1, MainCategoryId = 1, Name = "Bielizna" },
                new { Id = 2, MainCategoryId = 1, Name = "Buty wysokie" },
                new { Id = 3, MainCategoryId = 1, Name = "Buty wysokie" },
                new { Id = 4, MainCategoryId = 1, Name = "Czapki i kapelusze" },
                new { Id = 5, MainCategoryId = 1, Name = "Zimowe" },
                new { Id = 6, MainCategoryId = 2, Name = "Stroje kąpielowe" },
                new { Id = 7, MainCategoryId = 3, Name = "Spodnie" },
                new { Id = 8, MainCategoryId = 3, Name = "T-shirty i polo" },
                new { Id = 9, MainCategoryId = 4, Name = "Kombinezony" },
                new { Id = 10, MainCategoryId = 5, Name = "Topy" },
                new { Id = 11, MainCategoryId = 6, Name = "Czapki i kapelusze" },
                new { Id = 12, MainCategoryId = 6, Name = "Czapki i kapelusze" },
                new { Id = 13, MainCategoryId = 7, Name = "Spodnie" },
                new { Id = 14, MainCategoryId = 7, Name = "Szorty" },
                new { Id = 15, MainCategoryId = 8, Name = "Czapki i kapelusze" },
                new { Id = 16, MainCategoryId = 8, Name = "Kozaki i botki" },
                new { Id = 17, MainCategoryId = 8, Name = "Mokasyny i półbuty" },
                new { Id = 18, MainCategoryId = 8, Name = "Spódnice" },
                new { Id = 19, MainCategoryId = 8, Name = "Szpilki" },
                new { Id = 20, MainCategoryId = 9, Name = "Klapki i sandały" },
                new { Id = 21, MainCategoryId = 9, Name = "Klapki i sandały" },
                new { Id = 22, MainCategoryId = 9, Name = "Outdoor" },
                new { Id = 23, MainCategoryId = 10, Name = "Szpilki" },
                new { Id = 24, MainCategoryId = 10, Name = "Szpilki" },
                new { Id = 25, MainCategoryId = 11, Name = "Szaliki i chusty" },
                new { Id = 26, MainCategoryId = 12, Name = "Outdoor" },
                new { Id = 27, MainCategoryId = 12, Name = "Trampki i tenisówki" },
                new { Id = 28, MainCategoryId = 12, Name = "Trampki i tenisówki" },
                new { Id = 29, MainCategoryId = 13, Name = "Bluzy" },
                new { Id = 30, MainCategoryId = 13, Name = "Swetry" },
                new { Id = 31, MainCategoryId = 13, Name = "Swetry" },
                new { Id = 32, MainCategoryId = 14, Name = "Kozaki i botki" },
                new { Id = 33, MainCategoryId = 14, Name = "Sportowe i lifestyle" },
                new { Id = 34, MainCategoryId = 14, Name = "Żakiety" },
                new { Id = 35, MainCategoryId = 15, Name = "Bielizna" },
                new { Id = 36, MainCategoryId = 15, Name = "Kozaki i botki" },
                new { Id = 37, MainCategoryId = 15, Name = "Mokasyny i półbuty" },
                new { Id = 38, MainCategoryId = 15, Name = "Szpilki" },
                new { Id = 39, MainCategoryId = 16, Name = "Bielizna" },
                new { Id = 40, MainCategoryId = 17, Name = "Bluzki" },
                new { Id = 41, MainCategoryId = 17, Name = "Mokasyny i półbuty" },
                new { Id = 42, MainCategoryId = 18, Name = "Koszule" },
                new { Id = 43, MainCategoryId = 18, Name = "Topy" },
                new { Id = 44, MainCategoryId = 19, Name = "Bielizna" },
                new { Id = 45, MainCategoryId = 19, Name = "Klapki i sandały" },
                new { Id = 46, MainCategoryId = 19, Name = "Rajstopy i skarpetki" },
                new { Id = 47, MainCategoryId = 20, Name = "Kurtki i płaszcze" },
                new { Id = 48, MainCategoryId = 20, Name = "Mokasyny i półbuty" },
                new { Id = 49, MainCategoryId = 20, Name = "Sportowe i lifestyle" },
                new { Id = 50, MainCategoryId = 20, Name = "T-shirty i polo" },
                new { Id = 51, MainCategoryId = 21, Name = "Spodnie" },
                new { Id = 52, MainCategoryId = 21, Name = "Spodnie i legginsy" },
                new { Id = 53, MainCategoryId = 22, Name = "Bielizna" },
                new { Id = 54, MainCategoryId = 22, Name = "Kozaki i botki" },
                new { Id = 55, MainCategoryId = 22, Name = "Skarpety" },
                new { Id = 56, MainCategoryId = 23, Name = "Torebki" },
                new { Id = 57, MainCategoryId = 24, Name = "Pielęgnacja obuwia" },
                new { Id = 58, MainCategoryId = 24, Name = "Rajstopy i skarpetki" },
                new { Id = 59, MainCategoryId = 25, Name = "Pielęgnacja obuwia" },
                new { Id = 60, MainCategoryId = 26, Name = "Biżuteria" },
                new { Id = 61, MainCategoryId = 27, Name = "Biżuteria" },
                new { Id = 62, MainCategoryId = 27, Name = "Biżuteria" },
                new { Id = 63, MainCategoryId = 27, Name = "Portfele" },
                new { Id = 64, MainCategoryId = 27, Name = "Zegarki" },
                new { Id = 65, MainCategoryId = 28, Name = "Bielizna" },
                new { Id = 66, MainCategoryId = 28, Name = "Gadżety i akcesoria" },
                new { Id = 67, MainCategoryId = 28, Name = "Krawaty i muchy" },
                new { Id = 68, MainCategoryId = 28, Name = "Szaliki i chusty" },
                new { Id = 69, MainCategoryId = 29, Name = "Bielizna" },
                new { Id = 70, MainCategoryId = 29, Name = "Gadżety i akcesoria" },
                new { Id = 71, MainCategoryId = 29, Name = "Rajstopy i skarpetki" },
                new { Id = 72, MainCategoryId = 29, Name = "Rowery" },
                new { Id = 73, MainCategoryId = 30, Name = "Pielęgnacja obuwia" },
                new { Id = 74, MainCategoryId = 30, Name = "Pielęgnacja obuwia" },
                new { Id = 75, MainCategoryId = 31, Name = "Bielizna" },
                new { Id = 76, MainCategoryId = 31, Name = "Okulary" },
                new { Id = 77, MainCategoryId = 32, Name = "Bielizna" },
                new { Id = 78, MainCategoryId = 32, Name = "Krawaty i muchy" },
                new { Id = 79, MainCategoryId = 32, Name = "Krawaty i muchy" },
                new { Id = 80, MainCategoryId = 32, Name = "Słuchawki" },
                new { Id = 81, MainCategoryId = 33, Name = "Biżuteria" },
                new { Id = 82, MainCategoryId = 33, Name = "Książki i albumy" },
                new { Id = 83, MainCategoryId = 34, Name = "Biżuteria" },
                new { Id = 84, MainCategoryId = 35, Name = "Bielizna" },
                new { Id = 85, MainCategoryId = 35, Name = "Bokserki" },
                new { Id = 86, MainCategoryId = 35, Name = "Kalesony" },
                new { Id = 87, MainCategoryId = 35, Name = "Komplety" },
                new { Id = 88, MainCategoryId = 35, Name = "Kosmetyki" },
                new { Id = 89, MainCategoryId = 35, Name = "Kosmetyki" },
                new { Id = 90, MainCategoryId = 35, Name = "Pasy do pończoch" },
                new { Id = 91, MainCategoryId = 35, Name = "Slipy" },
                new { Id = 92, MainCategoryId = 35, Name = "Szaliki i chusty" },
                new { Id = 93, MainCategoryId = 36, Name = "Biżuteria" },
                new { Id = 94, MainCategoryId = 36, Name = "Breloki" },
                new { Id = 95, MainCategoryId = 36, Name = "Broszki" },
                new { Id = 96, MainCategoryId = 36, Name = "Dziecko" },
                new { Id = 97, MainCategoryId = 36, Name = "Dziecko" },
                new { Id = 98, MainCategoryId = 36, Name = "Dziecko" },
                new { Id = 99, MainCategoryId = 36, Name = "Dziecko" },
                new { Id = 100, MainCategoryId = 36, Name = "Inne" },
                new { Id = 101, MainCategoryId = 36, Name = "Pierścionki" },
                new { Id = 102, MainCategoryId = 37, Name = "Gadżety i akcesoria" },
                new { Id = 103, MainCategoryId = 37, Name = "Gadżety i akcesoria" },
                new { Id = 104, MainCategoryId = 37, Name = "Kosmetyki" },
                new { Id = 105, MainCategoryId = 37, Name = "Parasole" },
                new { Id = 106, MainCategoryId = 38, Name = "Autorskie grafiki" },
                new { Id = 107, MainCategoryId = 38, Name = "Dziecko" },
                new { Id = 108, MainCategoryId = 38, Name = "Elektronika" },
                new { Id = 109, MainCategoryId = 38, Name = "Kosmetyczki" },
                new { Id = 110, MainCategoryId = 38, Name = "Pokrowce" },
                new { Id = 111, MainCategoryId = 38, Name = "Ręczniki" },
                new { Id = 112, MainCategoryId = 39, Name = "Do ciała" },
                new { Id = 113, MainCategoryId = 39, Name = "Do makijażu" },
                new { Id = 114, MainCategoryId = 39, Name = "Do paznokci" },
                new { Id = 115, MainCategoryId = 39, Name = "Do twarzy" },
                new { Id = 116, MainCategoryId = 39, Name = "Do włosów" },
                new { Id = 117, MainCategoryId = 40, Name = "Krawaty" },
                new { Id = 118, MainCategoryId = 40, Name = "Muchy" },
                new { Id = 119, MainCategoryId = 40, Name = "Poszetki" },
                new { Id = 120, MainCategoryId = 41, Name = "Książki i albumy" },
                new { Id = 121, MainCategoryId = 42, Name = "Okulary" },
                new { Id = 122, MainCategoryId = 43, Name = "Parasole" },
                new { Id = 123, MainCategoryId = 44, Name = "Dziecko" },
                new { Id = 124, MainCategoryId = 45, Name = "Inne" },
                new { Id = 125, MainCategoryId = 45, Name = "Pasty i impregnaty" },
                new { Id = 126, MainCategoryId = 45, Name = "Szczotki i czyściki" },
                new { Id = 127, MainCategoryId = 45, Name = "Wkładki" },
                new { Id = 128, MainCategoryId = 46, Name = "Plecaki" },
                new { Id = 129, MainCategoryId = 47, Name = "Portfele" },
                new { Id = 130, MainCategoryId = 48, Name = "Kosmetyki" },
                new { Id = 131, MainCategoryId = 48, Name = "Pończochy" },
                new { Id = 132, MainCategoryId = 48, Name = "Skarpetki" },
                new { Id = 133, MainCategoryId = 49, Name = "Torby i walizki" },
                new { Id = 134, MainCategoryId = 50, Name = "Rowery" },
                new { Id = 135, MainCategoryId = 51, Name = "Kosmetyki" },
                new { Id = 136, MainCategoryId = 52, Name = "Słuchawki" },
                new { Id = 137, MainCategoryId = 53, Name = "Snowboard" },
                new { Id = 138, MainCategoryId = 54, Name = "Biżuteria" },
                new { Id = 139, MainCategoryId = 54, Name = "Chusty" },
                new { Id = 140, MainCategoryId = 54, Name = "Kominy" },
                new { Id = 141, MainCategoryId = 54, Name = "Szaliki" },
                new { Id = 142, MainCategoryId = 55, Name = "Na laptopa" },
                new { Id = 143, MainCategoryId = 55, Name = "Torby" },
                new { Id = 144, MainCategoryId = 55, Name = "Walizki" },
                new { Id = 145, MainCategoryId = 56, Name = "Casual (na co dzień)" },
                new { Id = 146, MainCategoryId = 56, Name = "Eleganckie" },
                new { Id = 147, MainCategoryId = 57, Name = "Zegarki" } 
                #endregion
                );

            builder.Entity<Component>().HasData(
                new { Id = 1, Name = "100% Bawełna" },
                new { Id = 2, Name = "98% Bawełna, 2 Poliester" },
                new { Id = 3, Name = "100% Poliester" },
                new { Id = 4, Name = "90% Poliester, 10% Elastan" }
                );

            builder.Entity<CountryOfOrigin>().HasData(
                new { Id = 1, Name = "Chiny" },
                new { Id = 2, Name = "Włochy" },
                new { Id = 3, Name = "Bangladesz" },
                new { Id = 4, Name = "Turcja" },
                new { Id = 5, Name = "Polska" }
                );

            builder.Entity<Supplier>().HasData(
                new { Id = 1, Name = "Alvaro" },
                new { Id = 2, Name = "La Casa del Papel" },
                new { Id = 3, Name = "Ing Ung Wang" },
                new { Id = 4, Name = "Neapolitana" }
                );

            builder.Entity<Size>().HasData(
                new { Id = 1, Name = "XS" },
                new { Id = 2, Name = "S" },
                new { Id = 3, Name = "M" },
                new { Id = 4, Name = "L" },
                new { Id = 5, Name = "XL" },
                new { Id = 6, Name = "S/M" },
                new { Id = 7, Name = "M/L" },
                new { Id = 8, Name = "36" },
                new { Id = 9, Name = "37" },
                new { Id = 10, Name = "37" },
                new { Id = 11, Name = "39" },
                new { Id = 12, Name = "40" },
                new { Id = 13, Name = "41" }
                );

            builder.Entity<CodeCn>().HasData(
                new { Id = 1, Name = "QWERT" },
                new { Id = 2, Name = "ASDFG" },
                new { Id = 3, Name = "YUIO" },
                new { Id = 4, Name = "VBNM" },
                new { Id = 5, Name = "LKJHGF" }
                );

            builder.Entity<Set>().HasData(
                new { Id = 1, Name = "Adventure Explorer" },
                new { Id = 2, Name = "Animal Instinct" },
                new { Id = 3, Name = "Advanced Retailer" },
                new { Id = 4, Name = "Braveheart Warior" },
                new { Id = 5, Name = "Elegant Summer" }
                );

            builder.Entity<ColorName>().HasData(
                new { Id = 1, Name = "Zielony" },
                new { Id = 2, Name = "Biały" },
                new { Id = 3, Name = "Czarny" },
                new { Id = 4, Name = "Niebieski" },
                new { Id = 5, Name = "Żółty" }
                );
            #endregion

            #region Business Trip Dropdown Values
            ///////////////////////////////
            builder.Entity<Country>().HasData(
                   new { Id = 1, Name = "Polska" },
                   new { Id = 2, Name = "Hiszpania" },
                   new { Id = 3, Name = "Włochy" },
                   new { Id = 4, Name = "Wielka Brytania" },
                   new { Id = 5, Name = "Francja" }
                   );

            builder.Entity<City>().HasData(
               new { Id = 1, Name = "Wólka Kosowska" },
               new { Id = 2, Name = "Paryż" },
               new { Id = 3, Name = "Birnimgham" },
               new { Id = 4, Name = "Madryt" },
               new { Id = 5, Name = "Prato" }
               );

            builder.Entity<Season>().HasData(
               new { Id = 1, Name = "WW18" },
               new { Id = 2, Name = "WP18" },
               new { Id = 3, Name = "WW19" },
               new { Id = 4, Name = "WP19" },
               new { Id = 5, Name = "WW20" }
               );

            builder.Entity<Currency>().HasData(
               new { Id = 1, Name = "PLN" },
               new { Id = 2, Name = "EURO" },
               new { Id = 3, Name = "FUNT" }
               );
            #endregion

            // Business Trips
            #region Business Trips - disabled
            //builder.Entity<BusinessTrip>().HasData(
            //    new { Id = 1, DateFrom = new DateTime(2018, 05, 06), DateTo = new DateTime(2018, 05, 09), CountryId = 1, CityId = 1, SeasonId = 3, CurrencyId = 1 },
            //    new { Id = 2, DateFrom = new DateTime(2018, 06, 20), DateTo = new DateTime(2018, 06, 22), CountryId = 3, CityId = 5, SeasonId = 4, CurrencyId = 2 },
            //    new { Id = 3, DateFrom = new DateTime(2018, 07, 03), DateTo = new DateTime(2018, 07, 09), CountryId = 4, CityId = 3, SeasonId = 4, CurrencyId = 3 }
            //    ); 
            #endregion

            // Pieces
            #region Pieces - disabled
            //builder.Entity<Piece>().HasData(
            //    new
            //    {
            //        Id = 1,
            //        Name = "SHIRT1122",
            //        BusinessTripId = 1,
            //        ColorId = 1,
            //        TopCategoryId = 1,
            //        MainCategoryId = 1,
            //        GroupId = 1,
            //        ComponentId = 1,
            //        CountryOfOriginId = 1,
            //        BuyPrice = 10.36,
            //        SellPrice = 32.32,
            //        SupplierId = 1,
            //        SizeId = 1,
            //        OrderDate = new DateTime(2018, 09, 05),
            //        EstimatedDateOfShipment = new DateTime(2018, 09, 15),
            //        EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
            //        Amount = 60,
            //        CodeCnId = 1,
            //        SetId = 1,
            //        ColorNameId = 1,
            //        ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
            //    },
            //    new
            //    {
            //        Id = 2,
            //        Name = "SHIRT1122",
            //        BusinessTripId = 1,
            //        ColorId = 1,
            //        TopCategoryId = 1,
            //        MainCategoryId = 1,
            //        GroupId = 1,
            //        ComponentId = 1,
            //        CountryOfOriginId = 1,
            //        BuyPrice = 10.36,
            //        SellPrice = 32.32,
            //        SupplierId = 1,
            //        SizeId = 2,
            //        OrderDate = new DateTime(2018, 09, 05),
            //        EstimatedDateOfShipment = new DateTime(2018, 09, 15),
            //        EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
            //        Amount = 80,
            //        CodeCnId = 1,
            //        SetId = 1,
            //        ColorNameId = 1,
            //        ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
            //    },
            //    new
            //    {
            //        Id = 3,
            //        Name = "SHIRT1122",
            //        BusinessTripId = 1,
            //        ColorId = 1,
            //        TopCategoryId = 1,
            //        MainCategoryId = 1,
            //        GroupId = 1,
            //        ComponentId = 1,
            //        CountryOfOriginId = 1,
            //        BuyPrice = 10.36,
            //        SellPrice = 32.32,
            //        SupplierId = 1,
            //        SizeId = 3,
            //        OrderDate = new DateTime(2018, 09, 05),
            //        EstimatedDateOfShipment = new DateTime(2018, 09, 15),
            //        EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
            //        Amount = 100,
            //        CodeCnId = 1,
            //        SetId = 1,
            //        ColorNameId = 1,
            //        ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
            //    }); 
            #endregion
        }

        public DbSet<BusinessTrip> BusinessTrips { get; set; }
        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<TopCategory> TopCategories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<CountryOfOrigin> CountryOfOrigin { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<CodeCn> CodeCns { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<ColorName> ColorNames { get; set; }
        public DbSet<SizeAmountPair> SizeAmountPairs { get; set; }

        //BusinessTrip Values

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        //public List<Piece> GetClothesByBusinessTripId(int id)
        //{
        //    return this.Pieces.ToList();
        //}

        //public List<BusinessTrip> GetBusinessTrips()
        //{
        //    return this.BusinessTrips.ToList();
        //}

        //public List<Piece> GetPieces()
        //{
        //    return this.Pieces.ToList();
        //}

    }


}
