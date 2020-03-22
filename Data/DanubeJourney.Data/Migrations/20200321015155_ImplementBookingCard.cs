using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DanubeJourney.Data.Migrations
{
    public partial class ImplementBookingCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingCards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    TripId = table.Column<string>(nullable: true),
                    RoomId = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingCards_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingCards_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingCards_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCards_IsDeleted",
                table: "BookingCards",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCards_RoomId",
                table: "BookingCards",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCards_TripId",
                table: "BookingCards",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCards_UserId",
                table: "BookingCards",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingCards");
        }
    }
}
