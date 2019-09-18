using Microsoft.EntityFrameworkCore.Migrations;

namespace Indecor.Migrations
{
    public partial class AddActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Active",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Categories");
        }
    }
}
