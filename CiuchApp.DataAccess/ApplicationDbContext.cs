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

            builder.Entity<MainCategory>().HasData(
                new { Id = 1, Name = "Sukienki i tuniki" },
                new { Id = 2, Name = "Buty" },
                new { Id = 3, Name = "Sandały i klapki" },
                new { Id = 4, Name = "Jeansy" },
                new { Id = 5, Name = "Koszule" }
                );

            builder.Entity<Group>().HasData(
                new { Id = 1, Name = "Eleganckie" },
                new { Id = 2, Name = "Sportowe" },
                new { Id = 3, Name = "Casual" },
                new { Id = 4, Name = "Wakacyjne" }
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

            builder.Entity<BusinessTrip>().HasData(
                new { Id = 1, DateFrom = new DateTime(2018, 05, 06), DateTo = new DateTime(2018, 05, 09), CountryId = 1, CityId = 1, SeasonId = 3, CurrencyId = 1 },
                new { Id = 2, DateFrom = new DateTime(2018, 06, 20), DateTo = new DateTime(2018, 06, 22), CountryId = 3, CityId = 5, SeasonId = 4, CurrencyId = 2 },
                new { Id = 3, DateFrom = new DateTime(2018, 07, 03), DateTo = new DateTime(2018, 07, 09), CountryId = 4, CityId = 3, SeasonId = 4, CurrencyId = 3 }
                );

            // Pieces

            builder.Entity<Piece>().HasData(
                new
                {
                    Id = 1,
                    Name = "SHIRT1122",
                    BusinessTripId = 1,
                    ColorId = 1,
                    MainCategoryId = 1,
                    GroupId = 1,
                    ComponentsId = 1,
                    CountryOfOriginId = 1,
                    BuyPrice = 10.36,
                    SellPrice = 32.32,
                    SupplierId = 1,
                    SizeId = 1,
                    OrderDate = new DateTime(2018, 09, 05),
                    EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                    EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                    Amount = 60,
                    CodeCnId = 1,
                    SetId = 1,
                    ColorNameId = 1,
                    ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
                },
                new
                {
                    Id = 2,
                    Name = "SHIRT1122",
                    BusinessTripId = 1,
                    ColorId = 1,
                    MainCategoryId = 1,
                    GroupId = 1,
                    ComponentsId = 1,
                    CountryOfOriginId = 1,
                    BuyPrice = 10.36,
                    SellPrice = 32.32,
                    SupplierId = 1,
                    SizeId = 2,
                    OrderDate = new DateTime(2018, 09, 05),
                    EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                    EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                    Amount = 80,
                    CodeCnId = 1,
                    SetId = 1,
                    ColorNameId = 1,
                    ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
                },
                new
                {
                    Id = 3,
                    Name = "SHIRT1122",
                    BusinessTripId = 1,
                    ColorId = 1,
                    MainCategoryId = 1,
                    GroupId = 1,
                    ComponentsId = 1,
                    CountryOfOriginId = 1,
                    BuyPrice = 10.36,
                    SellPrice = 32.32,
                    SupplierId = 1,
                    SizeId = 3,
                    OrderDate = new DateTime(2018, 09, 05),
                    EstimatedDateOfShipment = new DateTime(2018, 09, 15),
                    EstimatedTimeOfDelivery = new DateTime(2018, 09, 22),
                    Amount = 100,
                    CodeCnId = 1,
                    SetId = 1,
                    ColorNameId = 1,
                    ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg"
                });
        }

        public DbSet<BusinessTrip> BusinessTrips { get; set; }

        public DbSet<Piece> Pieces { get; set; }

        public DbSet<Color> Colors { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<CountryOfOrigin> CountryOfOrigin { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<CodeCn> CodeCns { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<ColorName> ColorNames { get; set; }

        //BusinessTrip Values

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        public List<Piece> GetClothesByBusinessTripId(int id)
        {
            return this.Pieces.ToList();
        }

        public List<BusinessTrip> GetBusinessTrips()
        {
            return this.BusinessTrips.ToList();
        }

        public List<Piece> GetPieces()
        {
            return this.Pieces.ToList();
        }

    }


}
