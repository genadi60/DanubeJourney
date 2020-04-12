using Microsoft.EntityFrameworkCore.Migrations;

namespace DanubeJourney.Data.Migrations
{
    public partial class UpgradeEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Ships",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Employees");
        }
    }
}
