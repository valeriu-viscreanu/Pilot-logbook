using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartTestApiDL.Migrations
{
    public partial class AddedPINtomodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PIN",
                table: "users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PIN",
                table: "users");
        }
    }
}
