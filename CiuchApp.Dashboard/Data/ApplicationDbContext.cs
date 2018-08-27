using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CiuchApp.Dashboard.Models;
using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Data
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
    }
}
