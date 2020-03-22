using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanubeJourney.Data.Migrations
{
    public partial class InitialEmploees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CaptainId",
                table: "Ships",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBird = table.Column<DateTime>(nullable: false),
                    Оccupation = table.Column<string>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    ShipId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Ships_ShipId",
                        column: x => x.ShipId,
                        principalTable: "Ships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CaptainId",
                table: "Ships",
                column: "CaptainId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IsDeleted",
                table: "Employees",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ShipId",
                table: "Employees",
                column: "ShipId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_Employees_CaptainId",
                table: "Ships",
                column: "CaptainId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ships_Employees_CaptainId",
                table: "Ships");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Ships_CaptainId",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CaptainId",
                table: "Ships");
        }
    }
}
