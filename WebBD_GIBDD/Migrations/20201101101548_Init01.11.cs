using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class Init0111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandAuto", x => x.ID);
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
                    Requirements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
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
                    Requirements = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.ID);
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
                    Phone = table.Column<long>(nullable: false),
                    PassportData = table.Column<string>(nullable: true),
                    PositionID = table.Column<long>(nullable: true),
                    RankID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Staff_Position_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Position",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Staff_Rank_RankID",
                        column: x => x.RankID,
                        principalTable: "Rank",
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
                    DriversLicenseNum = table.Column<long>(nullable: false),
                    DateIssueCertificate = table.Column<DateTime>(nullable: false),
                    EndDateCertificate = table.Column<DateTime>(nullable: false),
                    CategoryCertificate = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StaffID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Driver_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auto",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegNum = table.Column<string>(nullable: true),
                    NumberCarBody = table.Column<string>(nullable: true),
                    EngineNumber = table.Column<string>(nullable: true),
                    NumTechPass = table.Column<string>(nullable: true),
                    DateOfIssue = table.Column<DateTime>(nullable: false),
                    DateOfRegistration = table.Column<DateTime>(nullable: false),
                    COLOR = table.Column<string>(nullable: true),
                    TechInspection = table.Column<string>(nullable: true),
                    DateTechInspection = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BrandAutoID = table.Column<long>(nullable: true),
                    StaffID = table.Column<long>(nullable: true),
                    DriverID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auto", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auto_BrandAuto_BrandAutoID",
                        column: x => x.BrandAutoID,
                        principalTable: "BrandAuto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auto_Driver_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Driver",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auto_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                    DateFind = table.Column<DateTime>(nullable: false),
                    StaffID = table.Column<long>(nullable: true),
                    AutoID = table.Column<long>(nullable: true),
                    DriverID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsStolen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarsStolen_Auto_AutoID",
                        column: x => x.AutoID,
                        principalTable: "Auto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarsStolen_Driver_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Driver",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarsStolen_Staff_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staff",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auto_BrandAutoID",
                table: "Auto",
                column: "BrandAutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_DriverID",
                table: "Auto",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Auto_StaffID",
                table: "Auto",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_CarsStolen_AutoID",
                table: "CarsStolen",
                column: "AutoID");

            migrationBuilder.CreateIndex(
                name: "IX_CarsStolen_DriverID",
                table: "CarsStolen",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_CarsStolen_StaffID",
                table: "CarsStolen",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_StaffID",
                table: "Driver",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PositionID",
                table: "Staff",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RankID",
                table: "Staff",
                column: "RankID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsStolen");

            migrationBuilder.DropTable(
                name: "Auto");

            migrationBuilder.DropTable(
                name: "BrandAuto");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Rank");
        }
    }
}
