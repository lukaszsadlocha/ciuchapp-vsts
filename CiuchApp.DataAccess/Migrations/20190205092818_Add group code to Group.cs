using Microsoft.EntityFrameworkCore.Migrations;

namespace CiuchApp.DataAccess.Migrations
{
    public partial class AddgroupcodetoGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GroupCode",
                table: "Groups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupCode",
                table: "Groups");
        }
    }
}
