using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class _453 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "category_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "category_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category_name",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "Categories",
                newName: "Id");
        }
    }
}
