using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarsStolen",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStolen = table.Column<DateTime>(nullable: false),
                    DateAppeal = table.Column<DateTime>(nullable: false),
                    Circumstances = table.Column<string>(nullable: true),
                    MarkFind = table.Column<bool>(nullable: false),
                    DateFind = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsStolen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNum = table.Column<int>(nullable: false),
                    NumberCarBody = table.Column<string>(nullable: true),
                    EngineNumber = table.Column<int>(nullable: false),
                    DateSheetNumber = table.Column<DateTime>(nullable: false),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    DateOfRegistration = table.Column<DateTime>(nullable: false),
                    COLOR = table.Column<string>(nullable: true),
                    TechInspection = table.Column<string>(nullable: true),
                    DateTechInspection = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CarsStolenID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auto_CarsStolen_CarsStolenID",
                        column: x => x.CarsStolenID,
                        principalTable: "CarsStolen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BrandAuto",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyManufacturer = table.Column<string>(nullable: true),
                    CountryManufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StartProduction = table.Column<DateTime>(nullable: false),
                    EndProduction = table.Column<DateTime>(nullable: false),
                    Specifications = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    AutoID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandAuto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BrandAuto_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    DriversLicenseNum = table.Column<int>(nullable: false),
                    DateIssueCertificate = table.Column<DateTime>(nullable: false),
                    EndDateCertificate = table.Column<DateTime>(nullable: false),
                    CategoryCertificate = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AutoID = table.Column<long>(nullable: true),
                    CarsStolenID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Driver_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Driver_CarsStolen_CarsStolenID",
                        column: x => x.CarsStolenID,
                        principalTable: "CarsStolen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<short>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PassportData = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: true),
                    RankID = table.Column<long>(nullable: true),
                    AutoID = table.Column<long>(nullable: true),
                    CarsStolenID = table.Column<long>(nullable: true),
                    DriverID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_CarsStolen_CarsStolenID",
                        column: x => x.CarsStolenID,
                        principalTable: "CarsStolen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Driver_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Driver",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePosition = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Duties = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Position_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRank = table.Column<string>(nullable: true),
                    Salary = table.Column<int>(nullable: false),
                    Duties = table.Column<string>(nullable: true),
                    Requirements = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rank_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_CarsStolenID",
                table: "Auto",
                column: "CarsStolenID");

            migrationBuilder.CreateIndex(
                name: "IX_BrandAuto_AutoID",
                table: "BrandAuto",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_AutoID",
                table: "Driver",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_CarsStolenID",
                table: "Driver",
                column: "CarsStolenID");

            migrationBuilder.CreateIndex(
                name: "IX_Position_StaffID",
                table: "Position",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_StaffID",
                table: "Rank",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_AutoID",
                table: "Staff",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CarsStolenID",
                table: "Staff",
                column: "CarsStolenID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_DriverID",
                table: "Staff",
                column: "DriverID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandAuto");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "CarsStolen");
        }
    }
}
