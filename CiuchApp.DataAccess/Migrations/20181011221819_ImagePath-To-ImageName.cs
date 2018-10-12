using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class ImagePathToImageName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Pieces",
                newName: "ImageName");

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageName",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageName",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "Pieces",
                newName: "ImagePath");

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg");

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg");

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "fotyzwyjazdu/wyjazd1/SHIRT1122.jpg");
        }
    }
}
