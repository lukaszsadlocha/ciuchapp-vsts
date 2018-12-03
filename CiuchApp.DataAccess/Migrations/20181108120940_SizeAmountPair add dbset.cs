using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class SizeAmountPairadddbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeAmountPair_Pieces_PieceId",
                table: "SizeAmountPair");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAmountPair_Sizes_SizeId",
                table: "SizeAmountPair");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeAmountPair",
                table: "SizeAmountPair");

            migrationBuilder.RenameTable(
                name: "SizeAmountPair",
                newName: "SizeAmountPairs");

            migrationBuilder.RenameIndex(
                name: "IX_SizeAmountPair_SizeId",
                table: "SizeAmountPairs",
                newName: "IX_SizeAmountPairs_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_SizeAmountPair_PieceId",
                table: "SizeAmountPairs",
                newName: "IX_SizeAmountPairs_PieceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeAmountPairs",
                table: "SizeAmountPairs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAmountPairs_Pieces_PieceId",
                table: "SizeAmountPairs",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAmountPairs_Sizes_SizeId",
                table: "SizeAmountPairs",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SizeAmountPairs_Pieces_PieceId",
                table: "SizeAmountPairs");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeAmountPairs_Sizes_SizeId",
                table: "SizeAmountPairs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SizeAmountPairs",
                table: "SizeAmountPairs");

            migrationBuilder.RenameTable(
                name: "SizeAmountPairs",
                newName: "SizeAmountPair");

            migrationBuilder.RenameIndex(
                name: "IX_SizeAmountPairs_SizeId",
                table: "SizeAmountPair",
                newName: "IX_SizeAmountPair_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_SizeAmountPairs_PieceId",
                table: "SizeAmountPair",
                newName: "IX_SizeAmountPair_PieceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SizeAmountPair",
                table: "SizeAmountPair",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAmountPair_Pieces_PieceId",
                table: "SizeAmountPair",
                column: "PieceId",
                principalTable: "Pieces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeAmountPair_Sizes_SizeId",
                table: "SizeAmountPair",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
