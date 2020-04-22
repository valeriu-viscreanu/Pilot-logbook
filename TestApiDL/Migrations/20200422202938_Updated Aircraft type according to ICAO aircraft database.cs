using Microsoft.EntityFrameworkCore.Migrations;

namespace Logbook.DataLayer.Migrations
{
    public partial class UpdatedAircrafttypeaccordingtoICAOaircraftdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Make",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "AircraftType");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Designator",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EngineCount",
                table: "AircraftType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EngineType",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCode",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModelFullName",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WTC",
                table: "AircraftType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WTG",
                table: "AircraftType",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "Designator",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "EngineCount",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "EngineType",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "ManufacturerCode",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "ModelFullName",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "WTC",
                table: "AircraftType");

            migrationBuilder.DropColumn(
                name: "WTG",
                table: "AircraftType");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "AircraftType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "AircraftType",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
