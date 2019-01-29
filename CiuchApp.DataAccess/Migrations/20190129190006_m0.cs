using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class m0 : Migration
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
                name: "TopCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopCategories", x => x.Id);
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
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    TopCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainCategories_TopCategories_TopCategoryId",
                        column: x => x.TopCategoryId,
                        principalTable: "TopCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MainCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
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
                    TopCategoryId = table.Column<int>(nullable: false),
                    MainCategoryId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    ComponentId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    SellPrice = table.Column<double>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    EstimatedDateOfShipment = table.Column<DateTime>(nullable: false),
                    EstimatedTimeOfDelivery = table.Column<DateTime>(nullable: false),
                    CodeCnId = table.Column<int>(nullable: false),
                    SetId = table.Column<int>(nullable: false),
                    ColorNameId = table.Column<int>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    SizeId = table.Column<int>(nullable: true)
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pieces_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pieces_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pieces_TopCategories_TopCategoryId",
                        column: x => x.TopCategoryId,
                        principalTable: "TopCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SizeAmountPairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PieceId = table.Column<int>(nullable: false),
                    SizeId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeAmountPairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeAmountPairs_Pieces_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Pieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeAmountPairs_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
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
                    { 3, "Czarny" },
                    { 2, "Biały" },
                    { 1, "Zielony" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "KKE2111" },
                    { 3, "BLEW32" },
                    { 2, "OWTR20" },
                    { 1, "KLAM212" }
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
                    { 1, "Polska" },
                    { 2, "Hiszpania" },
                    { 3, "Włochy" },
                    { 4, "Wielka Brytania" },
                    { 5, "Francja" }
                });

            migrationBuilder.InsertData(
                table: "CountryOfOrigin",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Turcja" },
                    { 3, "Bangladesz" },
                    { 5, "Polska" },
                    { 1, "Chiny" },
                    { 2, "Włochy" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "PLN" },
                    { 2, "EURO" },
                    { 3, "FUNT" }
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
                    { 1, "Adventure Explorer" },
                    { 2, "Animal Instinct" },
                    { 3, "Advanced Retailer" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "37" },
                    { 12, "40" },
                    { 11, "39" },
                    { 13, "41" },
                    { 10, "37" },
                    { 8, "36" },
                    { 3, "M" },
                    { 6, "S/M" },
                    { 5, "XL" },
                    { 4, "L" },
                    { 2, "S" },
                    { 1, "XS" },
                    { 7, "M/L" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Alvaro" },
                    { 2, "La Casa del Papel" },
                    { 3, "Ing Ung Wang" },
                    { 4, "Neapolitana" }
                });

            migrationBuilder.InsertData(
                table: "TopCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Obuwie" },
                    { 1, "Odzież" },
                    { 3, "Akcesoria" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "Name", "TopCategoryId" },
                values: new object[,]
                {
                    { 1, "Bielizna", 1 },
                    { 31, "Sportowe i lifestyle", 2 },
                    { 32, "Szpilki", 2 },
                    { 33, "Trampki i tenisówki", 2 },
                    { 34, "Zimowe", 2 },
                    { 35, "Bielizna", 3 },
                    { 36, "Biżuteria", 3 },
                    { 37, "Czapki i kapelusze", 3 },
                    { 38, "Gadżety i akcesoria", 3 },
                    { 39, "Kosmetyki", 3 },
                    { 40, "Krawaty i muchy", 3 },
                    { 41, "Książki i albumy", 3 },
                    { 42, "Okulary", 3 },
                    { 43, "Parasole", 3 },
                    { 44, "Paski", 3 },
                    { 45, "Pielęgnacja obuwia", 3 },
                    { 46, "Plecaki", 3 },
                    { 47, "Portfele", 3 },
                    { 48, "Rajstopy i skarpetki", 3 },
                    { 49, "Rękawiczki", 3 },
                    { 50, "Rowery", 3 },
                    { 51, "Skarpety", 3 },
                    { 52, "Słuchawki", 3 },
                    { 53, "Snowboard", 3 },
                    { 54, "Szaliki i chusty", 3 },
                    { 55, "Torby i walizki", 3 },
                    { 30, "Outdoor", 2 },
                    { 56, "Torebki", 3 },
                    { 29, "Mokasyny i półbuty", 2 },
                    { 27, "Klapki i sandały", 2 },
                    { 2, "Bluzki", 1 },
                    { 3, "Bluzy", 1 },
                    { 4, "Jeansy", 1 },
                    { 5, "Kombinezony", 1 },
                    { 6, "Komplety i dresy", 1 },
                    { 7, "Koszule", 1 },
                    { 8, "Kurtki i płaszcze", 1 },
                    { 9, "Marynarki i garnitury", 1 },
                    { 10, "Materiały", 1 },
                    { 11, "Odzież niemowlęca", 1 },
                    { 12, "Snowboard", 1 },
                    { 13, "Spódnice", 1 },
                    { 14, "Spodnie", 1 },
                    { 15, "Spodnie i legginsy", 1 },
                    { 16, "Stroje kąpielowe", 1 },
                    { 17, "Sukienki i tuniki", 1 },
                    { 18, "Swetry", 1 },
                    { 19, "Szorty", 1 },
                    { 20, "T-shirty i polo", 1 },
                    { 21, "Topy", 1 },
                    { 22, "Żakiety", 1 },
                    { 23, "Baleriny", 2 },
                    { 24, "Buty wysokie", 2 },
                    { 25, "Dziecko", 2 },
                    { 26, "Kalosze", 2 },
                    { 28, "Kozaki i botki", 2 },
                    { 57, "Zegarki", 3 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "MainCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bielizna" },
                    { 95, 36, "Broszki" },
                    { 96, 36, "Dziecko" },
                    { 97, 36, "Dziecko" },
                    { 98, 36, "Dziecko" },
                    { 99, 36, "Dziecko" },
                    { 100, 36, "Inne" },
                    { 94, 36, "Breloki" },
                    { 101, 36, "Pierścionki" },
                    { 103, 37, "Gadżety i akcesoria" },
                    { 104, 37, "Kosmetyki" },
                    { 105, 37, "Parasole" },
                    { 106, 38, "Autorskie grafiki" },
                    { 107, 38, "Dziecko" },
                    { 108, 38, "Elektronika" },
                    { 102, 37, "Gadżety i akcesoria" },
                    { 93, 36, "Biżuteria" },
                    { 92, 35, "Szaliki i chusty" },
                    { 91, 35, "Slipy" },
                    { 76, 31, "Okulary" },
                    { 77, 32, "Bielizna" },
                    { 78, 32, "Krawaty i muchy" },
                    { 79, 32, "Krawaty i muchy" },
                    { 80, 32, "Słuchawki" },
                    { 81, 33, "Biżuteria" },
                    { 82, 33, "Książki i albumy" },
                    { 83, 34, "Biżuteria" },
                    { 84, 35, "Bielizna" },
                    { 85, 35, "Bokserki" },
                    { 86, 35, "Kalesony" },
                    { 87, 35, "Komplety" },
                    { 88, 35, "Kosmetyki" },
                    { 89, 35, "Kosmetyki" },
                    { 90, 35, "Pasy do pończoch" },
                    { 109, 38, "Kosmetyczki" },
                    { 75, 31, "Bielizna" },
                    { 110, 38, "Pokrowce" },
                    { 112, 39, "Do ciała" },
                    { 132, 48, "Skarpetki" },
                    { 133, 49, "Torby i walizki" },
                    { 134, 50, "Rowery" },
                    { 135, 51, "Kosmetyki" },
                    { 136, 52, "Słuchawki" },
                    { 137, 53, "Snowboard" },
                    { 131, 48, "Pończochy" },
                    { 138, 54, "Biżuteria" },
                    { 140, 54, "Kominy" },
                    { 141, 54, "Szaliki" },
                    { 142, 55, "Na laptopa" },
                    { 143, 55, "Torby" },
                    { 144, 55, "Walizki" },
                    { 145, 56, "Casual (na co dzień)" },
                    { 139, 54, "Chusty" },
                    { 130, 48, "Kosmetyki" },
                    { 129, 47, "Portfele" },
                    { 128, 46, "Plecaki" },
                    { 113, 39, "Do makijażu" },
                    { 114, 39, "Do paznokci" },
                    { 115, 39, "Do twarzy" },
                    { 116, 39, "Do włosów" },
                    { 117, 40, "Krawaty" },
                    { 118, 40, "Muchy" },
                    { 119, 40, "Poszetki" },
                    { 120, 41, "Książki i albumy" },
                    { 121, 42, "Okulary" },
                    { 122, 43, "Parasole" },
                    { 123, 44, "Dziecko" },
                    { 124, 45, "Inne" },
                    { 125, 45, "Pasty i impregnaty" },
                    { 126, 45, "Szczotki i czyściki" },
                    { 127, 45, "Wkładki" },
                    { 111, 38, "Ręczniki" },
                    { 146, 56, "Eleganckie" },
                    { 74, 30, "Pielęgnacja obuwia" },
                    { 72, 29, "Rowery" },
                    { 21, 9, "Klapki i sandały" },
                    { 22, 9, "Outdoor" },
                    { 23, 10, "Szpilki" },
                    { 24, 10, "Szpilki" },
                    { 25, 11, "Szaliki i chusty" },
                    { 26, 12, "Outdoor" },
                    { 20, 9, "Klapki i sandały" },
                    { 27, 12, "Trampki i tenisówki" },
                    { 29, 13, "Bluzy" },
                    { 30, 13, "Swetry" },
                    { 31, 13, "Swetry" },
                    { 32, 14, "Kozaki i botki" },
                    { 33, 14, "Sportowe i lifestyle" },
                    { 34, 14, "Żakiety" },
                    { 28, 12, "Trampki i tenisówki" },
                    { 19, 8, "Szpilki" },
                    { 18, 8, "Spódnice" },
                    { 17, 8, "Mokasyny i półbuty" },
                    { 2, 1, "Buty wysokie" },
                    { 3, 1, "Buty wysokie" },
                    { 4, 1, "Czapki i kapelusze" },
                    { 5, 1, "Zimowe" },
                    { 6, 2, "Stroje kąpielowe" },
                    { 7, 3, "Spodnie" },
                    { 8, 3, "T-shirty i polo" },
                    { 9, 4, "Kombinezony" },
                    { 10, 5, "Topy" },
                    { 11, 6, "Czapki i kapelusze" },
                    { 12, 6, "Czapki i kapelusze" },
                    { 13, 7, "Spodnie" },
                    { 14, 7, "Szorty" },
                    { 15, 8, "Czapki i kapelusze" },
                    { 16, 8, "Kozaki i botki" },
                    { 35, 15, "Bielizna" },
                    { 73, 30, "Pielęgnacja obuwia" },
                    { 36, 15, "Kozaki i botki" },
                    { 38, 15, "Szpilki" },
                    { 58, 24, "Rajstopy i skarpetki" },
                    { 59, 25, "Pielęgnacja obuwia" },
                    { 60, 26, "Biżuteria" },
                    { 61, 27, "Biżuteria" },
                    { 62, 27, "Biżuteria" },
                    { 63, 27, "Portfele" },
                    { 57, 24, "Pielęgnacja obuwia" },
                    { 64, 27, "Zegarki" },
                    { 66, 28, "Gadżety i akcesoria" },
                    { 67, 28, "Krawaty i muchy" },
                    { 68, 28, "Szaliki i chusty" },
                    { 69, 29, "Bielizna" },
                    { 70, 29, "Gadżety i akcesoria" },
                    { 71, 29, "Rajstopy i skarpetki" },
                    { 65, 28, "Bielizna" },
                    { 56, 23, "Torebki" },
                    { 55, 22, "Skarpety" },
                    { 54, 22, "Kozaki i botki" },
                    { 39, 16, "Bielizna" },
                    { 40, 17, "Bluzki" },
                    { 41, 17, "Mokasyny i półbuty" },
                    { 42, 18, "Koszule" },
                    { 43, 18, "Topy" },
                    { 44, 19, "Bielizna" },
                    { 45, 19, "Klapki i sandały" },
                    { 46, 19, "Rajstopy i skarpetki" },
                    { 47, 20, "Kurtki i płaszcze" },
                    { 48, 20, "Mokasyny i półbuty" },
                    { 49, 20, "Sportowe i lifestyle" },
                    { 50, 20, "T-shirty i polo" },
                    { 51, 21, "Spodnie" },
                    { 52, 21, "Spodnie i legginsy" },
                    { 53, 22, "Bielizna" },
                    { 37, 15, "Mokasyny i półbuty" },
                    { 147, 57, "Zegarki" }
                });

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
                name: "IX_Groups_MainCategoryId",
                table: "Groups",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MainCategories_TopCategoryId",
                table: "MainCategories",
                column: "TopCategoryId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_TopCategoryId",
                table: "Pieces",
                column: "TopCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeAmountPairs_PieceId",
                table: "SizeAmountPairs",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeAmountPairs_SizeId",
                table: "SizeAmountPairs",
                column: "SizeId");
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
                name: "SizeAmountPairs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pieces");

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

            migrationBuilder.DropTable(
                name: "MainCategories");

            migrationBuilder.DropTable(
                name: "TopCategories");
        }
    }
}
