using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class addCnCodetoGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CnCode",
                table: "Groups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "CnCode",
                value: "6212900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "CnCode",
                value: "6208920000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "CnCode",
                value: "6112319000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "CnCode",
                value: "6208920000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "CnCode",
                value: "6212900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7,
                column: "CnCode",
                value: "6110309900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8,
                column: "CnCode",
                value: "6110309900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9,
                column: "CnCode",
                value: "6204623990");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10,
                column: "CnCode",
                value: "6211439000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11,
                column: "CnCode",
                value: "6112110000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12,
                column: "CnCode",
                value: "6104230000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14,
                column: "CnCode",
                value: "6206300090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15,
                column: "CnCode",
                value: "6202930000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16,
                column: "CnCode",
                value: "6202930000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17,
                column: "CnCode",
                value: "6202930000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19,
                column: "CnCode",
                value: "6202930000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20,
                column: "CnCode",
                value: "6203120000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21,
                column: "CnCode",
                value: "6211324100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22,
                column: "CnCode",
                value: "6203339000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26,
                column: "CnCode",
                value: "6211200090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27,
                column: "CnCode",
                value: "6210500000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28,
                column: "CnCode",
                value: "6210500000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29,
                column: "CnCode",
                value: "6104530000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30,
                column: "CnCode",
                value: "6104530000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31,
                column: "CnCode",
                value: "6104530000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32,
                column: "CnCode",
                value: "6204623990");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 33,
                column: "CnCode",
                value: "6203423500");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 34,
                column: "CnCode",
                value: "6204623990");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 35,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 36,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 37,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 38,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 39,
                column: "CnCode",
                value: "6112419000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 40,
                column: "CnCode",
                value: "6204430000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 41,
                column: "CnCode",
                value: "6204430000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 42,
                column: "CnCode",
                value: "6110309900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 43,
                column: "CnCode",
                value: "6110309900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 44,
                column: "CnCode",
                value: "6204639090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 45,
                column: "CnCode",
                value: "6204639090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 46,
                column: "CnCode",
                value: "6204639090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 47,
                column: "CnCode",
                value: "6109100090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 48,
                column: "CnCode",
                value: "6105100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 49,
                column: "CnCode",
                value: "6109100010");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 50,
                column: "CnCode",
                value: "6109100090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 51,
                column: "CnCode",
                value: "6109902000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 52,
                column: "CnCode",
                value: "6109902000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 53,
                column: "CnCode",
                value: "6204339000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 54,
                column: "CnCode",
                value: "6204339000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 55,
                column: "CnCode",
                value: "6211324100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 56,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 57,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 58,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 59,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 60,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 61,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 62,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 63,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 64,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 65,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 66,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 67,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 68,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 69,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 70,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 71,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 72,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 73,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 74,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 75,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 76,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 77,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 78,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 79,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 80,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 81,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 82,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 83,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 84,
                column: "CnCode",
                value: "6212109000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 85,
                column: "CnCode",
                value: "6107110000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 86,
                column: "CnCode",
                value: "6107110000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 87,
                column: "CnCode",
                value: "6212101000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 88,
                column: "CnCode",
                value: "6109100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 89,
                column: "CnCode",
                value: "6108210000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 90,
                column: "CnCode",
                value: "6212200000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 91,
                column: "CnCode",
                value: "6108310000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 92,
                column: "CnCode",
                value: "6107110000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 93,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 94,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 95,
                column: "CnCode",
                value: "7326909890");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 96,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 97,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 98,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 99,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 100,
                column: "CnCode",
                value: "9615190000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 101,
                column: "CnCode",
                value: "7117900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 102,
                column: "CnCode",
                value: "6505003000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 103,
                column: "CnCode",
                value: "6505009090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 104,
                column: "CnCode",
                value: "6505009090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 105,
                column: "CnCode",
                value: "6505009090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 106,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 107,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 108,
                column: "CnCode",
                value: "4202990090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 109,
                column: "CnCode",
                value: "4202921100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 110,
                column: "CnCode",
                value: "4202990090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 111,
                column: "CnCode",
                value: "6302600000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 112,
                column: "CnCode",
                value: "3304990000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 113,
                column: "CnCode",
                value: "3304990000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 114,
                column: "CnCode",
                value: "3304300000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 115,
                column: "CnCode",
                value: "3304990000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 116,
                column: "CnCode",
                value: "3305900000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 117,
                column: "CnCode",
                value: "6215200000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 118,
                column: "CnCode",
                value: "6215200000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 119,
                column: "CnCode",
                value: "6217100090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 120,
                column: "CnCode",
                value: "4901990000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 121,
                column: "CnCode",
                value: "9004109100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 122,
                column: "CnCode",
                value: "6601999000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 123,
                column: "CnCode",
                value: "3926200000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 124,
                column: "CnCode",
                value: "6307909899");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 125,
                column: "CnCode",
                value: "3405100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 126,
                column: "CnCode",
                value: "9603909100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 127,
                column: "CnCode",
                value: "6406909090");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 128,
                column: "CnCode",
                value: "4202929190");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 129,
                column: "CnCode",
                value: "4202321000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 130,
                column: "CnCode",
                value: "6115301900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 131,
                column: "CnCode",
                value: "6115220000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 132,
                column: "CnCode",
                value: "6115969900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 133,
                column: "CnCode",
                value: "6116930000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 134,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 135,
                column: "CnCode",
                value: "6115969900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 136,
                column: "CnCode",
                value: "8518309590");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 137,
                column: "CnCode",
                value: "");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 138,
                column: "CnCode",
                value: "6117100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 139,
                column: "CnCode",
                value: "6117100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 140,
                column: "CnCode",
                value: "6117100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 141,
                column: "CnCode",
                value: "6117100000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 142,
                column: "CnCode",
                value: "4202121100");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 143,
                column: "CnCode",
                value: "4202121900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 144,
                column: "CnCode",
                value: "4202121900");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 145,
                column: "CnCode",
                value: "4202221000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 146,
                column: "CnCode",
                value: "4202221000");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 147,
                column: "CnCode",
                value: "9102110000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CnCode",
                table: "Groups");
        }
    }
}
