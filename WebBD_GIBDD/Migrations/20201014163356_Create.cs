using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "AutoID",
                table: "CarsStolen",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DriverID",
                table: "CarsStolen",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "CarsStolen",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutoID",
                table: "CarsStolen");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "CarsStolen");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "CarsStolen");
        }
    }
}
