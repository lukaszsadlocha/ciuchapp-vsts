using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChiuchApp.WebApi.Core3.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    MainCategory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pieces",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pieces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pieces_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "MainCategory", "Name" },
                values: new object[] { new Guid("11111111-6a49-4a8b-bd00-ad3cc8e85924"), new DateTimeOffset(new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Obouwie dla Niej i dla Niego", "Odzież", "Buty" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "MainCategory", "Name" },
                values: new object[] { new Guid("22222222-6a49-4a8b-bd00-ad3cc8e85924"), new DateTimeOffset(new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Okulary przeciwsłoneczne i korekcyjne", "Dodatki", "Okulary" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Created", "Description", "MainCategory", "Name" },
                values: new object[] { new Guid("33333333-6a49-4a8b-bd00-ad3cc8e85924"), new DateTimeOffset(new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Sukienki dla Niej", "Odzież", "Sukienki" });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[] { new Guid("11111111-1111-4a8b-bd00-ad3cc8e85924"), new Guid("11111111-6a49-4a8b-bd00-ad3cc8e85924"), "Białe półtrampki Converse", "Converse" });

            migrationBuilder.CreateIndex(
                name: "IX_Pieces_CategoryId",
                table: "Pieces",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pieces");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
