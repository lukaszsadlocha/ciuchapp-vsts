using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CodeCns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CodeCns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryOfOrigin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryOfOrigin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessTrips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false),
                    CurrencyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessTrips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessTrips_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessTrips_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessTrips_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusinessTrips_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pieces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    BusinessTripId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    MainCategoryId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ComponentId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    EstimatedDateOfShipment = table.Column<DateTime>(nullable: false),
                    EstimatedTimeOfDelivery = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    CodeCnId = table.Column<int>(nullable: false),
                    SetId = table.Column<int>(nullable: false),
                    ColorNameId = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pieces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pieces_BusinessTrips_BusinessTripId",
                        column: x => x.BusinessTripId,
                        principalTable: "BusinessTrips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_CodeCns_CodeCnId",
                        column: x => x.CodeCnId,
                        principalTable: "CodeCns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_ColorNames_ColorNameId",
                        column: x => x.ColorNameId,
                        principalTable: "ColorNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_CountryOfOrigin_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "CountryOfOrigin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Sets_SetId",
                        column: x => x.SetId,
                        principalTable: "Sets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wólka Kosowska" },
                    { 2, "Paryż" },
                    { 3, "Birnimgham" },
                    { 4, "Madryt" },
                    { 5, "Prato" }
                });

            migrationBuilder.InsertData(
                table: "CodeCns",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "QWERT" },
                    { 2, "ASDFG" },
                    { 3, "YUIO" },
                    { 4, "VBNM" },
                    { 5, "LKJHGF" }
                });

            migrationBuilder.InsertData(
                table: "ColorNames",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Żółty" },
                    { 4, "Niebieski" },
                    { 2, "Biały" },
                    { 1, "Zielony" },
                    { 3, "Czarny" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "BLEW32" },
                    { 2, "OWTR20" },
                    { 1, "KLAM212" },
                    { 4, "KKE2111" }
                });

            migrationBuilder.InsertData(
                table: "Components",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "100% Bawełna" },
                    { 2, "98% Bawełna, 2 Poliester" },
                    { 3, "100% Poliester" },
                    { 4, "90% Poliester, 10% Elastan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Francja" },
                    { 4, "Wielka Brytania" },
                    { 2, "Hiszpania" },
                    { 1, "Polska" },
                    { 3, "Włochy" }
                });

            migrationBuilder.InsertData(
                table: "CountryOfOrigin",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Polska" },
                    { 1, "Chiny" },
                    { 2, "Włochy" },
                    { 3, "Bangladesz" },
                    { 4, "Turcja" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "EURO" },
                    { 3, "FUNT" },
                    { 1, "PLN" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Eleganckie" },
                    { 2, "Sportowe" },
                    { 3, "Casual" },
                    { 4, "Wakacyjne" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Koszule" },
                    { 3, "Sandały i klapki" },
                    { 4, "Jeansy" },
                    { 1, "Sukienki i tuniki" },
                    { 2, "Buty" }
                });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "WW18" },
                    { 2, "WP18" },
                    { 3, "WW19" },
                    { 4, "WP19" },
                    { 5, "WW20" }
                });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Elegant Summer" },
                    { 4, "Braveheart Warior" },
                    { 2, "Animal Instinct" },
                    { 1, "Adventure Explorer" },
                    { 3, "Advanced Retailer" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 13, "41" },
                    { 1, "XS" },
                    { 2, "S" },
                    { 3, "M" },
                    { 4, "L" },
                    { 5, "XL" },
                    { 6, "S/M" },
                    { 7, "M/L" },
                    { 8, "36" },
                    { 9, "37" },
                    { 10, "37" },
                    { 11, "39" },
                    { 12, "40" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "La Casa del Papel" },
                    { 3, "Ing Ung Wang" },
                    { 1, "Alvaro" },
                    { 4, "Neapolitana" }
                });

            migrationBuilder.InsertData(
                table: "BusinessTrips",
                columns: new[] { "Id", "CityId", "CountryId", "CurrencyId", "DateFrom", "DateTo", "SeasonId" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2018, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "BusinessTrips",
                columns: new[] { "Id", "CityId", "CountryId", "CurrencyId", "DateFrom", "DateTo", "SeasonId" },
                values: new object[] { 2, 5, 3, 2, new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "BusinessTrips",
                columns: new[] { "Id", "CityId", "CountryId", "CurrencyId", "DateFrom", "DateTo", "SeasonId" },
                values: new object[] { 3, 3, 4, 3, new DateTime(2018, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImageName", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 1, 60, 1, 10.36, 1, 1, 1, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImageName", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 2, 80, 1, 10.36, 1, 1, 1, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImageName", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 3, 100, 1, 10.36, 1, 1, 1, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 3, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_CityId",
                table: "BusinessTrips",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_CountryId",
                table: "BusinessTrips",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_CurrencyId",
                table: "BusinessTrips",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessTrips_SeasonId",
                table: "BusinessTrips",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_BusinessTripId",
                table: "Pieces",
                column: "BusinessTripId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_CodeCnId",
                table: "Pieces",
                column: "CodeCnId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ColorId",
                table: "Pieces",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ColorNameId",
                table: "Pieces",
                column: "ColorNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_ComponentId",
                table: "Pieces",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_CountryOfOriginId",
                table: "Pieces",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_GroupId",
                table: "Pieces",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_MainCategoryId",
                table: "Pieces",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_SetId",
                table: "Pieces",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_SizeId",
                table: "Pieces",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_SupplierId",
                table: "Pieces",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Pieces");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "BusinessTrips");

            migrationBuilder.DropTable(
                name: "CodeCns");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "ColorNames");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "CountryOfOrigin");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Seasons");
        }
    }
}
