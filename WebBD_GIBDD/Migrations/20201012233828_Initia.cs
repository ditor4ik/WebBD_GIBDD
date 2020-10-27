using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class Initia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateSheetNumber",
                table: "Auto");

            migrationBuilder.AddColumn<long>(
                name: "BrandAutoID",
                table: "Auto",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DriverID",
                table: "Auto",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NumTechPass",
                table: "Auto",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "Auto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandAutoID",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "NumTechPass",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Auto");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSheetNumber",
                table: "Auto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
