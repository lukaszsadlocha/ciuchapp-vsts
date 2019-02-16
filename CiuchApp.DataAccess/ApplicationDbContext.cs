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

            builder.Entity<City>().
                HasOne(x => x.Country).
                WithMany(x => x.Cities).
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
                new { Id = 1, MainCategoryId = 1, Name = "Body", GroupCode = "BI", CnCode = "6212900000" },
                new { Id = 2, MainCategoryId = 1, Name = "Inne", GroupCode = "BI", CnCode = "6208920000" },
                new { Id = 3, MainCategoryId = 1, Name = "Kąpielówki", GroupCode = "BI", CnCode = "6112319000" },
                new { Id = 4, MainCategoryId = 1, Name = "Szlafroki", GroupCode = "BI", CnCode = "6208920000" },
                new { Id = 5, MainCategoryId = 1, Name = "Wyszczuplająca", GroupCode = "BI", CnCode = "6212900000" },
                new { Id = 6, MainCategoryId = 2, Name = "Z długim rękawem", GroupCode = "BU", CnCode = "" },
                new { Id = 7, MainCategoryId = 3, Name = "Przez głowę", GroupCode = "BL", CnCode = "6110309900" },
                new { Id = 8, MainCategoryId = 3, Name = "Rozpinane", GroupCode = "BL", CnCode = "6110309900" },
                new { Id = 9, MainCategoryId = 4, Name = "Jeansy", GroupCode = "SJ", CnCode = "6204623990" },
                new { Id = 10, MainCategoryId = 5, Name = "Kombinezony", GroupCode = "SK", CnCode = "6211439000" },
                new { Id = 11, MainCategoryId = 6, Name = "Dresy", GroupCode = "DK", CnCode = "6112110000" },
                new { Id = 12, MainCategoryId = 6, Name = "Komplety", GroupCode = "DK", CnCode = "6104230000" },
                new { Id = 13, MainCategoryId = 7, Name = "Z długim rękawem", GroupCode = "KD", CnCode = "" },
                new { Id = 14, MainCategoryId = 7, Name = "Z krótkim rękawem", GroupCode = "KK", CnCode = "6206300090" },
                new { Id = 15, MainCategoryId = 8, Name = "Bezrękawniki", GroupCode = "KU", CnCode = "6202930000" },
                new { Id = 16, MainCategoryId = 8, Name = "Kurtki długie", GroupCode = "KU", CnCode = "6202930000" },
                new { Id = 17, MainCategoryId = 8, Name = "Kurtki krótkie", GroupCode = "KU", CnCode = "6202930000" },
                new { Id = 18, MainCategoryId = 8, Name = "Płaszcze", GroupCode = "KP", CnCode = "" },
                new { Id = 19, MainCategoryId = 8, Name = "Poncha", GroupCode = "KU", CnCode = "6202930000" },
                new { Id = 20, MainCategoryId = 9, Name = "Garnitury", GroupCode = "KZ", CnCode = "6203120000" },
                new { Id = 21, MainCategoryId = 9, Name = "Kamizelki", GroupCode = "KZ", CnCode = "6211324100" },
                new { Id = 22, MainCategoryId = 9, Name = "Marynarki", GroupCode = "KZ", CnCode = "6203339000" },
                new { Id = 23, MainCategoryId = 10, Name = "Materiały", GroupCode = "MT", CnCode = "" },
                new { Id = 24, MainCategoryId = 10, Name = "Metki", GroupCode = "ML", CnCode = "" },
                new { Id = 25, MainCategoryId = 11, Name = "Odzież niemowlęca", GroupCode = "ON", CnCode = "" },
                new { Id = 26, MainCategoryId = 12, Name = "Kombinezony", GroupCode = "KU", CnCode = "6211200090" },
                new { Id = 27, MainCategoryId = 12, Name = "Kurtki", GroupCode = "KU", CnCode = "6210500000" },
                new { Id = 28, MainCategoryId = 12, Name = "Spodnie", GroupCode = "SP", CnCode = "6210500000" },
                new { Id = 29, MainCategoryId = 13, Name = "Maxi", GroupCode = "SD", CnCode = "6104530000" },
                new { Id = 30, MainCategoryId = 13, Name = "Midi", GroupCode = "SD", CnCode = "6104530000" },
                new { Id = 31, MainCategoryId = 13, Name = "Mini", GroupCode = "SD", CnCode = "6104530000" },
                new { Id = 32, MainCategoryId = 14, Name = "Casual (na co dzień)", GroupCode = "SP", CnCode = "6204623990" },
                new { Id = 33, MainCategoryId = 14, Name = "Eleganckie", GroupCode = "SP", CnCode = "6203423500" },
                new { Id = 34, MainCategoryId = 14, Name = "Sportowe", GroupCode = "SP", CnCode = "6204623990" },
                new { Id = 35, MainCategoryId = 15, Name = "Casual (na co dzień)", GroupCode = "SP", CnCode = "" },
                new { Id = 36, MainCategoryId = 15, Name = "Eleganckie", GroupCode = "SP", CnCode = "" },
                new { Id = 37, MainCategoryId = 15, Name = "Legginsy", GroupCode = "LG", CnCode = "" },
                new { Id = 38, MainCategoryId = 15, Name = "Sportowe", GroupCode = "SP", CnCode = "" },
                new { Id = 39, MainCategoryId = 16, Name = "Stroje kąpielowe", GroupCode = "BI", CnCode = "6112419000" },
                new { Id = 40, MainCategoryId = 17, Name = "Casual (na co dzień)", GroupCode = "SU", CnCode = "6204430000" },
                new { Id = 41, MainCategoryId = 17, Name = "Eleganckie", GroupCode = "SU", CnCode = "6204430000" },
                new { Id = 42, MainCategoryId = 18, Name = "Przez głowę", GroupCode = "SW", CnCode = "6110309900" },
                new { Id = 43, MainCategoryId = 18, Name = "Rozpinane", GroupCode = "SW", CnCode = "6110309900" },
                new { Id = 44, MainCategoryId = 19, Name = "Casual (na co dzień)", GroupCode = "SZ", CnCode = "6204639090" },
                new { Id = 45, MainCategoryId = 19, Name = "Eleganckie", GroupCode = "SZ", CnCode = "6204639090" },
                new { Id = 46, MainCategoryId = 19, Name = "Sportowe", GroupCode = "SZ", CnCode = "6204639090" },
                new { Id = 47, MainCategoryId = 20, Name = "Bez rękawów", GroupCode = "TS", CnCode = "6109100090" },
                new { Id = 48, MainCategoryId = 20, Name = "Polo", GroupCode = "PO", CnCode = "6105100000" },
                new { Id = 49, MainCategoryId = 20, Name = "T-shirty", GroupCode = "TS", CnCode = "6109100010" },
                new { Id = 50, MainCategoryId = 20, Name = "Z długim rękawem", GroupCode = "BU", CnCode = "6109100090" },
                new { Id = 51, MainCategoryId = 21, Name = "Bez rękawów", GroupCode = "TS", CnCode = "6109902000" },
                new { Id = 52, MainCategoryId = 21, Name = "Z krótkim rękawem", GroupCode = "TS", CnCode = "6109902000" },
                new { Id = 53, MainCategoryId = 22, Name = "Casual (na co dzień)", GroupCode = "KZ", CnCode = "6204339000" },
                new { Id = 54, MainCategoryId = 22, Name = "Eleganckie", GroupCode = "KZ", CnCode = "6204339000" },
                new { Id = 55, MainCategoryId = 22, Name = "Kamizelki", GroupCode = "KZ", CnCode = "6211324100" },
                new { Id = 56, MainCategoryId = 23, Name = "Baleriny", GroupCode = "OB", CnCode = "" },
                new { Id = 57, MainCategoryId = 24, Name = "Casual (na co dzień)", GroupCode = "OB", CnCode = "" },
                new { Id = 58, MainCategoryId = 24, Name = "Eleganckie", GroupCode = "OB", CnCode = "" },
                new { Id = 59, MainCategoryId = 25, Name = "Kozaki", GroupCode = "OD", CnCode = "" },
                new { Id = 60, MainCategoryId = 26, Name = "Kalosze", GroupCode = "OB", CnCode = "" },
                new { Id = 61, MainCategoryId = 27, Name = "Japonki", GroupCode = "KL", CnCode = "" },
                new { Id = 62, MainCategoryId = 27, Name = "Klapki", GroupCode = "KL", CnCode = "" },
                new { Id = 63, MainCategoryId = 27, Name = "Koturny i espadryle", GroupCode = "OB", CnCode = "" },
                new { Id = 64, MainCategoryId = 27, Name = "Sandały", GroupCode = "OB", CnCode = "" },
                new { Id = 65, MainCategoryId = 28, Name = "Botki", GroupCode = "OB", CnCode = "" },
                new { Id = 66, MainCategoryId = 28, Name = "Kozaki", GroupCode = "OB", CnCode = "" },
                new { Id = 67, MainCategoryId = 28, Name = "Oficerki", GroupCode = "OB", CnCode = "" },
                new { Id = 68, MainCategoryId = 28, Name = "Śniegowce", GroupCode = "OB", CnCode = "" },
                new { Id = 69, MainCategoryId = 29, Name = "Casual (na co dzień)", GroupCode = "OB", CnCode = "" },
                new { Id = 70, MainCategoryId = 29, Name = "Mokasyny", GroupCode = "OB", CnCode = "" },
                new { Id = 71, MainCategoryId = 29, Name = "Półbuty", GroupCode = "OB", CnCode = "" },
                new { Id = 72, MainCategoryId = 29, Name = "Wizytowe", GroupCode = "OB", CnCode = "" },
                new { Id = 73, MainCategoryId = 30, Name = "Outdoor", GroupCode = "OB", CnCode = "" },
                new { Id = 74, MainCategoryId = 30, Name = "Sandały", GroupCode = "OB", CnCode = "" },
                new { Id = 75, MainCategoryId = 31, Name = "Lifestyle", GroupCode = "OB", CnCode = "" },
                new { Id = 76, MainCategoryId = 31, Name = "Sportowe", GroupCode = "OB", CnCode = "" },
                new { Id = 77, MainCategoryId = 32, Name = "Czółenka", GroupCode = "OB", CnCode = "" },
                new { Id = 78, MainCategoryId = 32, Name = "Peep toe", GroupCode = "OB", CnCode = "" },
                new { Id = 79, MainCategoryId = 32, Name = "Sandały na obcasie", GroupCode = "OB", CnCode = "" },
                new { Id = 80, MainCategoryId = 32, Name = "Szpilki", GroupCode = "OB", CnCode = "" },
                new { Id = 81, MainCategoryId = 33, Name = "Niskie", GroupCode = "OB", CnCode = "" },
                new { Id = 82, MainCategoryId = 33, Name = "Wysokie", GroupCode = "OB", CnCode = "" },
                new { Id = 83, MainCategoryId = 34, Name = "Zimowe", GroupCode = "OB", CnCode = "" },
                new { Id = 84, MainCategoryId = 35, Name = "Biustonosze", GroupCode = "BI", CnCode = "6212109000" },
                new { Id = 85, MainCategoryId = 35, Name = "Bokserki", GroupCode = "BI", CnCode = "6107110000" },
                new { Id = 86, MainCategoryId = 35, Name = "Kalesony", GroupCode = "BI", CnCode = "6107110000" },
                new { Id = 87, MainCategoryId = 35, Name = "Komplety", GroupCode = "BI", CnCode = "6212101000" },
                new { Id = 88, MainCategoryId = 35, Name = "Koszulki", GroupCode = "BI", CnCode = "6109100000" },
                new { Id = 89, MainCategoryId = 35, Name = "Majtki", GroupCode = "BI", CnCode = "6108210000" },
                new { Id = 90, MainCategoryId = 35, Name = "Pasy do pończoch", GroupCode = "AK", CnCode = "6212200000" },
                new { Id = 91, MainCategoryId = 35, Name = "Piżamy", GroupCode = "BI", CnCode = "6108310000" },
                new { Id = 92, MainCategoryId = 35, Name = "Slipy", GroupCode = "BI", CnCode = "6107110000" },
                new { Id = 93, MainCategoryId = 36, Name = "Biżuteria", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 94, MainCategoryId = 36, Name = "Bransoletki", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 95, MainCategoryId = 36, Name = "Breloki", GroupCode = "AK", CnCode = "7326909890" },
                new { Id = 96, MainCategoryId = 36, Name = "Broszki", GroupCode = "AK", CnCode = "" },
                new { Id = 97, MainCategoryId = 36, Name = "Inne", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 98, MainCategoryId = 36, Name = "Kolczyki", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 99, MainCategoryId = 36, Name = "Naszyjniki", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 100, MainCategoryId = 36, Name = "Ozdoby do włosów", GroupCode = "AK", CnCode = "9615190000" },
                new { Id = 101, MainCategoryId = 36, Name = "Pierścionki", GroupCode = "AK", CnCode = "7117900000" },
                new { Id = 102, MainCategoryId = 37, Name = "Czapki z daszkiem", GroupCode = "CA", CnCode = "6505003000" },
                new { Id = 103, MainCategoryId = 37, Name = "Czapki zimowe", GroupCode = "CA", CnCode = "6505009090" },
                new { Id = 104, MainCategoryId = 37, Name = "Kapelusze", GroupCode = "CA", CnCode = "6505009090" },
                new { Id = 105, MainCategoryId = 37, Name = "Kaszkiety i berety", GroupCode = "CA", CnCode = "6505009090" },
                new { Id = 106, MainCategoryId = 38, Name = "Autorskie grafiki", GroupCode = "AK", CnCode = "" },
                new { Id = 107, MainCategoryId = 38, Name = "Elektronika", GroupCode = "AK", CnCode = "" },
                new { Id = 108, MainCategoryId = 38, Name = "Inne", GroupCode = "RO", CnCode = "4202990090" },
                new { Id = 109, MainCategoryId = 38, Name = "Kosmetyczki", GroupCode = "AK", CnCode = "4202921100" },
                new { Id = 110, MainCategoryId = 38, Name = "Pokrowce", GroupCode = "AK", CnCode = "4202990090" },
                new { Id = 111, MainCategoryId = 38, Name = "Ręczniki", GroupCode = "AK", CnCode = "6302600000" },
                new { Id = 112, MainCategoryId = 39, Name = "Do ciała", GroupCode = "AK", CnCode = "3304990000" },
                new { Id = 113, MainCategoryId = 39, Name = "Do makijażu", GroupCode = "AK", CnCode = "3304990000" },
                new { Id = 114, MainCategoryId = 39, Name = "Do paznokci", GroupCode = "AK", CnCode = "3304300000" },
                new { Id = 115, MainCategoryId = 39, Name = "Do twarzy", GroupCode = "AK", CnCode = "3304990000" },
                new { Id = 116, MainCategoryId = 39, Name = "Do włosów", GroupCode = "AK", CnCode = "3305900000" },
                new { Id = 117, MainCategoryId = 40, Name = "Krawaty", GroupCode = "AK", CnCode = "6215200000" },
                new { Id = 118, MainCategoryId = 40, Name = "Muchy", GroupCode = "AK", CnCode = "6215200000" },
                new { Id = 119, MainCategoryId = 40, Name = "Poszetki", GroupCode = "AK", CnCode = "6217100090" },
                new { Id = 120, MainCategoryId = 41, Name = "Książki i albumy", GroupCode = "AK", CnCode = "4901990000" },
                new { Id = 121, MainCategoryId = 42, Name = "Okulary", GroupCode = "OK", CnCode = "9004109100" },
                new { Id = 122, MainCategoryId = 43, Name = "Parasole", GroupCode = "AK", CnCode = "6601999000" },
                new { Id = 123, MainCategoryId = 44, Name = "Paski", GroupCode = "PA", CnCode = "3926200000" },
                new { Id = 124, MainCategoryId = 45, Name = "Inne", GroupCode = "AK", CnCode = "6307909899" },
                new { Id = 125, MainCategoryId = 45, Name = "Pasty i impregnaty", GroupCode = "AK", CnCode = "3405100000" },
                new { Id = 126, MainCategoryId = 45, Name = "Szczotki i czyściki", GroupCode = "AK", CnCode = "9603909100" },
                new { Id = 127, MainCategoryId = 45, Name = "Wkładki", GroupCode = "AK", CnCode = "6406909090" },
                new { Id = 128, MainCategoryId = 46, Name = "Plecaki", GroupCode = "PK", CnCode = "4202929190" },
                new { Id = 129, MainCategoryId = 47, Name = "Portfele", GroupCode = "PF", CnCode = "4202321000" },
                new { Id = 130, MainCategoryId = 48, Name = "Pończochy", GroupCode = "LG", CnCode = "6115301900" },
                new { Id = 131, MainCategoryId = 48, Name = "Rajstopy", GroupCode = "LG", CnCode = "6115220000" },
                new { Id = 132, MainCategoryId = 48, Name = "Skarpetki", GroupCode = "LG", CnCode = "6115969900" },
                new { Id = 133, MainCategoryId = 49, Name = "Rękawiczki", GroupCode = "RE", CnCode = "6116930000" },
                new { Id = 134, MainCategoryId = 50, Name = "Rowery", GroupCode = "AK", CnCode = "" },
                new { Id = 135, MainCategoryId = 51, Name = "Skarpety", GroupCode = "LG", CnCode = "6115969900" },
                new { Id = 136, MainCategoryId = 52, Name = "Słuchawki", GroupCode = "AK", CnCode = "8518309590" },
                new { Id = 137, MainCategoryId = 53, Name = "Rękawiczki", GroupCode = "AK", CnCode = "" },
                new { Id = 138, MainCategoryId = 54, Name = "Chusty", GroupCode = "SA", CnCode = "6117100000" },
                new { Id = 139, MainCategoryId = 54, Name = "Kominy", GroupCode = "SA", CnCode = "6117100000" },
                new { Id = 140, MainCategoryId = 54, Name = "Szale", GroupCode = "SA", CnCode = "6117100000" },
                new { Id = 141, MainCategoryId = 54, Name = "Szaliki", GroupCode = "SA", CnCode = "6117100000" },
                new { Id = 142, MainCategoryId = 55, Name = "Na laptopa", GroupCode = "TO", CnCode = "4202121100" },
                new { Id = 143, MainCategoryId = 55, Name = "Torby", GroupCode = "TO", CnCode = "4202121900" },
                new { Id = 144, MainCategoryId = 55, Name = "Walizki", GroupCode = "TO", CnCode = "4202121900" },
                new { Id = 145, MainCategoryId = 56, Name = "Casual (na co dzień)", GroupCode = "TO", CnCode = "4202221000" },
                new { Id = 146, MainCategoryId = 56, Name = "Eleganckie", GroupCode = "TO", CnCode = "4202221000" },
                new { Id = 147, MainCategoryId = 57, Name = "Zegarki", GroupCode = "AK", CnCode = "9102110000" }
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
                   new { Id = 5, Name = "Francja" },
                   new { Id = 6, Name = "Chiny" },
                   new { Id = 7, Name = "Turcja" }
                   );

            builder.Entity<City>().HasData(
               new { Id = 1, CountryId=1, Name = "Wólka Kosowska" },
               new { Id = 2, CountryId=2, Name = "Paryż" },
               new { Id = 3, CountryId=4, Name = "Londyn" },
               new { Id = 4, CountryId=4, Name = "Manchester" },
               new { Id = 5, CountryId=2, Name = "Madryt" },
               new { Id = 6, CountryId=3, Name = "Prato" },
               new { Id = 7, CountryId=7, Name = "Istambuł" },
               new { Id = 8, CountryId=6, Name = "Guangzhou" }
               );

            builder.Entity<Season>().HasData(
               new { Id = 1, Name = "WW19" },
               new { Id = 2, Name = "WZ19" },
               new { Id = 3, Name = "WS19" },
               new { Id = 4, Name = "WA19" },

               new { Id = 5, Name = "WW20" },
               new { Id = 6, Name = "WZ20" },
               new { Id = 7, Name = "WS20" },
               new { Id = 8, Name = "WA20" },

               new { Id = 9, Name = "WW21" },
               new { Id = 10, Name = "WZ21" },
               new { Id = 11, Name = "WS21" },
               new { Id = 12, Name = "WA21" }

               );

            builder.Entity<Currency>().HasData(
               new { Id = 1, Name = "PLN" },
               new { Id = 2, Name = "EURO" },
               new { Id = 3, Name = "FUNT" },
               new { Id = 4, Name = "DOLAR" }
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
