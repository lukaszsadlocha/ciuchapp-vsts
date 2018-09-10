﻿// <auto-generated />
using System;
using CiuchApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CiuchApp.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180908051550_Values for Pieces")]
    partial class ValuesforPieces
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CiuchApp.DataAccess.AspNetIdentity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CiuchApp.Domain.BusinessTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<int>("CountryId");

                    b.Property<int>("CurrencyId");

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<int>("SeasonId");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("SeasonId");

                    b.ToTable("BusinessTrips");

                    b.HasData(
                        new { Id = 1, CityId = 1, CountryId = 1, CurrencyId = 1, DateFrom = new DateTime(2018, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), DateTo = new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), SeasonId = 3 },
                        new { Id = 2, CityId = 5, CountryId = 3, CurrencyId = 2, DateFrom = new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), DateTo = new DateTime(2018, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), SeasonId = 4 },
                        new { Id = 3, CityId = 3, CountryId = 4, CurrencyId = 3, DateFrom = new DateTime(2018, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), DateTo = new DateTime(2018, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), SeasonId = 4 }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, Name = "Wólka Kosowska" },
                        new { Id = 2, Name = "Paryż" },
                        new { Id = 3, Name = "Birnimgham" },
                        new { Id = 4, Name = "Madryt" },
                        new { Id = 5, Name = "Prato" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.CodeCn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CodeCns");

                    b.HasData(
                        new { Id = 1, Name = "QWERT" },
                        new { Id = 2, Name = "ASDFG" },
                        new { Id = 3, Name = "YUIO" },
                        new { Id = 4, Name = "VBNM" },
                        new { Id = 5, Name = "LKJHGF" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new { Id = 1, Name = "KLAM212" },
                        new { Id = 2, Name = "OWTR20" },
                        new { Id = 3, Name = "BLEW32" },
                        new { Id = 4, Name = "KKE2111" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.ColorName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ColorNames");

                    b.HasData(
                        new { Id = 1, Name = "Zielony" },
                        new { Id = 2, Name = "Biały" },
                        new { Id = 3, Name = "Czarny" },
                        new { Id = 4, Name = "Niebieski" },
                        new { Id = 5, Name = "Żółty" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Components");

                    b.HasData(
                        new { Id = 1, Name = "100% Bawełna" },
                        new { Id = 2, Name = "98% Bawełna, 2 Poliester" },
                        new { Id = 3, Name = "100% Poliester" },
                        new { Id = 4, Name = "90% Poliester, 10% Elastan" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Name = "Polska" },
                        new { Id = 2, Name = "Hiszpania" },
                        new { Id = 3, Name = "Włochy" },
                        new { Id = 4, Name = "Wielka Brytania" },
                        new { Id = 5, Name = "Francja" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.CountryOfOrigin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CountryOfOrigin");

                    b.HasData(
                        new { Id = 1, Name = "Chiny" },
                        new { Id = 2, Name = "Włochy" },
                        new { Id = 3, Name = "Bangladesz" },
                        new { Id = 4, Name = "Turcja" },
                        new { Id = 5, Name = "Polska" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new { Id = 1, Name = "PLN" },
                        new { Id = 2, Name = "EURO" },
                        new { Id = 3, Name = "FUNT" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new { Id = 1, Name = "Eleganckie" },
                        new { Id = 2, Name = "Sportowe" },
                        new { Id = 3, Name = "Casual" },
                        new { Id = 4, Name = "Wakacyjne" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");

                    b.HasData(
                        new { Id = 1, Name = "Sukienki i tuniki" },
                        new { Id = 2, Name = "Buty" },
                        new { Id = 3, Name = "Sandały i klapki" },
                        new { Id = 4, Name = "Jeansy" },
                        new { Id = 5, Name = "Koszule" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Piece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("BusinessTripId");

                    b.Property<double>("BuyPrice");

                    b.Property<int>("CodeCnId");

                    b.Property<int>("ColorId");

                    b.Property<int>("ColorNameId");

                    b.Property<int?>("ComponentId");

                    b.Property<int>("ComponentsId");

                    b.Property<int>("CountryOfOriginId");

                    b.Property<DateTime>("EstimatedDateOfShipment");

                    b.Property<DateTime>("EstimatedTimeOfDelivery");

                    b.Property<int>("GroupId");

                    b.Property<string>("ImagePath");

                    b.Property<int>("MainCategoryId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("OrderDate");

                    b.Property<double>("SellPrice");

                    b.Property<int>("SetId");

                    b.Property<int>("SizeId");

                    b.Property<int>("SupplierId");

                    b.HasKey("Id");

                    b.HasIndex("BusinessTripId");

                    b.HasIndex("CodeCnId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ColorNameId");

                    b.HasIndex("ComponentId");

                    b.HasIndex("CountryOfOriginId");

                    b.HasIndex("GroupId");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("SetId");

                    b.HasIndex("SizeId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Pieces");

                    b.HasData(
                        new { Id = 1, Amount = 60, BusinessTripId = 1, BuyPrice = 10.36, CodeCnId = 1, ColorId = 1, ColorNameId = 1, ComponentsId = 1, CountryOfOriginId = 1, EstimatedDateOfShipment = new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), EstimatedTimeOfDelivery = new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), GroupId = 1, ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", MainCategoryId = 1, Name = "SHIRT1122", OrderDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), SellPrice = 32.32, SetId = 1, SizeId = 1, SupplierId = 1 },
                        new { Id = 2, Amount = 80, BusinessTripId = 1, BuyPrice = 10.36, CodeCnId = 1, ColorId = 1, ColorNameId = 1, ComponentsId = 1, CountryOfOriginId = 1, EstimatedDateOfShipment = new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), EstimatedTimeOfDelivery = new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), GroupId = 1, ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", MainCategoryId = 1, Name = "SHIRT1122", OrderDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), SellPrice = 32.32, SetId = 1, SizeId = 2, SupplierId = 1 },
                        new { Id = 3, Amount = 100, BusinessTripId = 1, BuyPrice = 10.36, CodeCnId = 1, ColorId = 1, ColorNameId = 1, ComponentsId = 1, CountryOfOriginId = 1, EstimatedDateOfShipment = new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), EstimatedTimeOfDelivery = new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), GroupId = 1, ImagePath = "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", MainCategoryId = 1, Name = "SHIRT1122", OrderDate = new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), SellPrice = 32.32, SetId = 1, SizeId = 3, SupplierId = 1 }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Seasons");

                    b.HasData(
                        new { Id = 1, Name = "WW18" },
                        new { Id = 2, Name = "WP18" },
                        new { Id = 3, Name = "WW19" },
                        new { Id = 4, Name = "WP19" },
                        new { Id = 5, Name = "WW20" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Sets");

                    b.HasData(
                        new { Id = 1, Name = "Adventure Explorer" },
                        new { Id = 2, Name = "Animal Instinct" },
                        new { Id = 3, Name = "Advanced Retailer" },
                        new { Id = 4, Name = "Braveheart Warior" },
                        new { Id = 5, Name = "Elegant Summer" }
                    );
                });

            modelBuilder.Entity("CiuchApp.Domain.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Sizes");

                    b.HasData(
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
                });

            modelBuilder.Entity("CiuchApp.Domain.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new { Id = 1, Name = "Alvaro" },
                        new { Id = 2, Name = "La Casa del Papel" },
                        new { Id = 3, Name = "Ing Ung Wang" },
                        new { Id = 4, Name = "Neapolitana" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CiuchApp.Domain.BusinessTrip", b =>
                {
                    b.HasOne("CiuchApp.Domain.City", "City")
                        .WithMany("BusinessTrips")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Country", "Country")
                        .WithMany("BusinessTrips")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Currency", "Currency")
                        .WithMany("BusinessTrips")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Season", "Season")
                        .WithMany("BusinessTrips")
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CiuchApp.Domain.Piece", b =>
                {
                    b.HasOne("CiuchApp.Domain.BusinessTrip", "BusinessTrip")
                        .WithMany()
                        .HasForeignKey("BusinessTripId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.CodeCn", "CodeCn")
                        .WithMany("Pieces")
                        .HasForeignKey("CodeCnId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Color", "Color")
                        .WithMany("Pieces")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.ColorName", "ColorName")
                        .WithMany("Pieces")
                        .HasForeignKey("ColorNameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Component", "Component")
                        .WithMany("Pieces")
                        .HasForeignKey("ComponentId");

                    b.HasOne("CiuchApp.Domain.CountryOfOrigin", "CountryOfOrigin")
                        .WithMany("Pieces")
                        .HasForeignKey("CountryOfOriginId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Group", "Group")
                        .WithMany("Pieces")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.MainCategory", "MainCategory")
                        .WithMany("Pieces")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Set", "Set")
                        .WithMany("Pieces")
                        .HasForeignKey("SetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Size", "Size")
                        .WithMany("Pieces")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.Domain.Supplier", "Supplier")
                        .WithMany("Pieces")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CiuchApp.DataAccess.AspNetIdentity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CiuchApp.DataAccess.AspNetIdentity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiuchApp.DataAccess.AspNetIdentity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CiuchApp.DataAccess.AspNetIdentity.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}