using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class PlayerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2,
                column: "team",
                value: "Gambit");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 3,
                column: "team",
                value: "Vision Strikers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 2,
                column: "team",
                value: "Russia");

            migrationBuilder.UpdateData(
                table: "Player",
                keyColumn: "Id",
                keyValue: 3,
                column: "team",
                value: "Korea");
        }
    }
}
