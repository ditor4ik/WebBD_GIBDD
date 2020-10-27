using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class InitialCre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "DriversLicenseNum",
                table: "Driver",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "Driver",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Driver");

            migrationBuilder.AlterColumn<int>(
                name: "DriversLicenseNum",
                table: "Driver",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
