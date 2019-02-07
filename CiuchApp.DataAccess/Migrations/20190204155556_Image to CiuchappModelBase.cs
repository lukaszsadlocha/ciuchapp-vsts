using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class ImagetoCiuchappModelBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "TopCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Suppliers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Sizes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "SizeAmountPairs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Sets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Seasons",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "MainCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Groups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Currencies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "CountryOfOrigin",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Components",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Colors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "ColorNames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "CodeCns",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "BusinessTrips",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "TopCategories");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Sizes");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "SizeAmountPairs");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "MainCategories");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "CountryOfOrigin");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "ColorNames");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "CodeCns");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "BusinessTrips");
        }
    }
}
