using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Logbook.DataLayer.Migrations
{
    public partial class AcAcTypeandFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.AddColumn<int>(
                name: "FlightsFlightId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AircraftType",
                columns: table => new
                {
                    AircraftTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftType", x => x.AircraftTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Aircraft",
                columns: table => new
                {
                    AircraftId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Registration = table.Column<string>(nullable: true),
                    TypeAircraftTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircraft", x => x.AircraftId);
                    table.ForeignKey(
                        name: "FK_Aircraft_AircraftType_TypeAircraftTypeId",
                        column: x => x.TypeAircraftTypeId,
                        principalTable: "AircraftType",
                        principalColumn: "AircraftTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AircraftId = table.Column<int>(nullable: true),
                    TakeoffTime = table.Column<DateTime>(nullable: false),
                    LandingTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Flight_Aircraft_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircraft",
                        principalColumn: "AircraftId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_FlightsFlightId",
                table: "Users",
                column: "FlightsFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircraft_TypeAircraftTypeId",
                table: "Aircraft",
                column: "TypeAircraftTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_AircraftId",
                table: "Flight",
                column: "AircraftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Flight_FlightsFlightId",
                table: "Users",
                column: "FlightsFlightId",
                principalTable: "Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Flight_FlightsFlightId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Aircraft");

            migrationBuilder.DropTable(
                name: "AircraftType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_FlightsFlightId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FlightsFlightId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }
    }
}
