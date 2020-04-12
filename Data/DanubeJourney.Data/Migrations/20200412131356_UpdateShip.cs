using System.Net.Mime;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanubeJourney.Data.Migrations
{
    public partial class UpdateShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ships",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ships");
        }
    }
}
