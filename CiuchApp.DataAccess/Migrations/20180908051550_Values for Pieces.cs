using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class ValuesforPieces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "ComponentsId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImagePath", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 1, 60, 1, 10.36, 1, 1, 1, null, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "ComponentsId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImagePath", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 2, 80, 1, 10.36, 1, 1, 1, null, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Pieces",
                columns: new[] { "Id", "Amount", "BusinessTripId", "BuyPrice", "CodeCnId", "ColorId", "ColorNameId", "ComponentId", "ComponentsId", "CountryOfOriginId", "EstimatedDateOfShipment", "EstimatedTimeOfDelivery", "GroupId", "ImagePath", "MainCategoryId", "Name", "OrderDate", "SellPrice", "SetId", "SizeId", "SupplierId" },
                values: new object[] { 3, 100, 1, 10.36, 1, 1, 1, null, 1, 1, new DateTime(2018, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg", 1, "SHIRT1122", new DateTime(2018, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 32.32, 1, 3, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
