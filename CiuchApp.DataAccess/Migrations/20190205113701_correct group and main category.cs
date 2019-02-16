using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class correctgroupandmaincategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Body" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Inne" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Kąpielówki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Szlafroki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Wyszczuplająca" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BU", "Z długim rękawem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BL", "Przez głowę" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BL", "Rozpinane" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SJ", "Jeansy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SK", "Kombinezony" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "DK", "Dresy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "DK", "Komplety" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KD", "Z długim rękawem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KK", "Z krótkim rękawem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Bezrękawniki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Kurtki długie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Kurtki krótkie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KP", "Płaszcze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Poncha" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Garnitury" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Kamizelki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Marynarki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "MT", "Materiały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "ML", "Metki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "ON", "Odzież niemowlęca" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Kombinezony" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KU", "Kurtki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Spodnie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SD", "Maxi" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SD", "Midi" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SD", "Mini" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Sportowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "LG", "Legginsy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SP", "Sportowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Stroje kąpielowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SU", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SU", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SW", "Przez głowę" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SW", "Rozpinane" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SZ", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SZ", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SZ", "Sportowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "TS", "Bez rękawów" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "PO", "Polo" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "TS", "T-shirty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BU", "Z długim rękawem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "TS", "Bez rękawów" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "TS", "Z krótkim rękawem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KZ", "Kamizelki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Baleriny" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Eleganckie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OD", "Kozaki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Kalosze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KL", "Japonki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "KL", "Klapki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Koturny i espadryle" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Sandały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Botki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Kozaki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Oficerki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Śniegowce" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Casual (na co dzień)" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Mokasyny" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Półbuty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Wizytowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Sandały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Lifestyle" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Sportowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Czółenka" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Peep toe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Sandały na obcasie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Szpilki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Niskie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Wysokie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "OB", "Zimowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Biustonosze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 85,
                column: "GroupCode",
                value: "BI");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 86,
                column: "GroupCode",
                value: "BI");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 87,
                column: "GroupCode",
                value: "BI");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Koszulki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Majtki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 90,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Piżamy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "BI", "Slipy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 93,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Bransoletki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Breloki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Broszki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Inne" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Kolczyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Naszyjniki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Ozdoby do włosów" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 101,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "CA", "Czapki z daszkiem" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "CA", "Czapki zimowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "CA", "Kapelusze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "CA", "Kaszkiety i berety" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 106,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Elektronika" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "RO", "Inne" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 109,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 110,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 111,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 112,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 113,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 114,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 115,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 116,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 117,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 118,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 119,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 120,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 121,
                column: "GroupCode",
                value: "OK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 122,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "PA", "Paski" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 124,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 125,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 126,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 127,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 128,
                column: "GroupCode",
                value: "PK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 129,
                column: "GroupCode",
                value: "PF");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "LG", "Pończochy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "LG", "Rajstopy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 132,
                column: "GroupCode",
                value: "LG");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "RE", "Rękawiczki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 134,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "LG", "Skarpety" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 136,
                column: "GroupCode",
                value: "AK");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "AK", "Rękawiczki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SA", "Chusty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SA", "Kominy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { "SA", "Szale" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 141,
                column: "GroupCode",
                value: "SA");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 142,
                column: "GroupCode",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 143,
                column: "GroupCode",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 144,
                column: "GroupCode",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 145,
                column: "GroupCode",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 146,
                column: "GroupCode",
                value: "TO");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 147,
                column: "GroupCode",
                value: "AK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Buty wysokie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Buty wysokie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Czapki i kapelusze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Zimowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Stroje kąpielowe" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Spodnie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "T-shirty i polo" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kombinezony" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Topy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Czapki i kapelusze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Czapki i kapelusze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Spodnie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szorty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Czapki i kapelusze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kozaki i botki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Mokasyny i półbuty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Spódnice" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szpilki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Klapki i sandały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Klapki i sandały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szpilki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szpilki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szaliki i chusty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Outdoor" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Trampki i tenisówki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Trampki i tenisówki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bluzy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Swetry" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Swetry" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kozaki i botki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Sportowe i lifestyle" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Żakiety" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kozaki i botki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Mokasyny i półbuty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szpilki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bluzki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Mokasyny i półbuty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Koszule" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Topy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Klapki i sandały" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Rajstopy i skarpetki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kurtki i płaszcze" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Mokasyny i półbuty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Sportowe i lifestyle" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "T-shirty i polo" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Spodnie" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Spodnie i legginsy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kozaki i botki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Skarpety" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Torebki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Pielęgnacja obuwia" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Rajstopy i skarpetki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Pielęgnacja obuwia" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Portfele" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Zegarki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Gadżety i akcesoria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Krawaty i muchy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szaliki i chusty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Gadżety i akcesoria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Rajstopy i skarpetki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Rowery" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Pielęgnacja obuwia" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Pielęgnacja obuwia" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Okulary" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Krawaty i muchy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Krawaty i muchy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Słuchawki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Książki i albumy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Bielizna" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 85,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 86,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 87,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kosmetyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kosmetyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 90,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Slipy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Szaliki i chusty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 93,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Breloki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Broszki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Inne" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 101,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Gadżety i akcesoria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Gadżety i akcesoria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kosmetyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Parasole" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 106,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Elektronika" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 109,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 110,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 111,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 112,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 113,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 114,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 115,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 116,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 117,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 118,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 119,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 120,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 121,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 122,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Dziecko" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 124,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 125,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 126,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 127,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 128,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 129,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kosmetyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Pończochy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 132,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Torby i walizki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 134,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kosmetyki" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 136,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Snowboard" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Biżuteria" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Chusty" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "GroupCode", "Name" },
                values: new object[] { null, "Kominy" });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 141,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 142,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 143,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 144,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 145,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 146,
                column: "GroupCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 147,
                column: "GroupCode",
                value: null);
        }
    }
}
