using Microsoft.EntityFrameworkCore.Migrations;

namespace WebBD_GIBDD.Migrations
{
    public partial class Init3110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Position_Staff_StaffID",
                table: "Position");

            migrationBuilder.DropForeignKey(
                name: "FK_Rank_Staff_StaffID",
                table: "Rank");

            migrationBuilder.DropIndex(
                name: "IX_Rank_StaffID",
                table: "Rank");

            migrationBuilder.DropIndex(
                name: "IX_Position_StaffID",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Rank");

            migrationBuilder.DropColumn(
                name: "StaffID",
                table: "Position");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_PositionID",
                table: "Staff",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_RankID",
                table: "Staff",
                column: "RankID");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Position_PositionID",
                table: "Staff",
                column: "PositionID",
                principalTable: "Position",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Rank_RankID",
                table: "Staff",
                column: "RankID",
                principalTable: "Rank",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Position_PositionID",
                table: "Staff");

            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Rank_RankID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_PositionID",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_RankID",
                table: "Staff");

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "Rank",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StaffID",
                table: "Position",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rank_StaffID",
                table: "Rank",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Position_StaffID",
                table: "Position",
                column: "StaffID");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Staff_StaffID",
                table: "Position",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rank_Staff_StaffID",
                table: "Rank",
                column: "StaffID",
                principalTable: "Staff",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
