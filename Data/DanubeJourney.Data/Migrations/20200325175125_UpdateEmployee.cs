using Microsoft.EntityFrameworkCore.Migrations;

namespace DanubeJourney.Data.Migrations
{
    public partial class UpdateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Оccupation",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Profession",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profession",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Оccupation",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
