using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class Add_SizeAmountPair : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pieces_Sizes_SizeId",
                table: "Pieces");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Pieces");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Pieces",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "SizeAmountPair",
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
                    table.PrimaryKey("PK_SizeAmountPair", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeAmountPair_Pieces_PieceId",
                        column: x => x.PieceId,
                        principalTable: "Pieces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeAmountPair_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SizeAmountPair_PieceId",
                table: "SizeAmountPair",
                column: "PieceId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeAmountPair_SizeId",
                table: "SizeAmountPair",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pieces_Sizes_SizeId",
                table: "Pieces",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pieces_Sizes_SizeId",
                table: "Pieces");

            migrationBuilder.DropTable(
                name: "SizeAmountPair");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Pieces",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Pieces",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 80);

            migrationBuilder.UpdateData(
                table: "Pieces",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 100);

            migrationBuilder.AddForeignKey(
                name: "FK_Pieces_Sizes_SizeId",
                table: "Pieces",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
