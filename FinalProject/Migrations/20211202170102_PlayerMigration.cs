using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class PlayerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    imgURL = table.Column<string>(nullable: true),
                    team = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    clip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "Id", "clip", "description", "imgURL", "name", "team" },
                values: new object[] { 1, null, "IGL", "https://liquipedia.net/commons/images/b/b4/Sentinels_ShahZaM_may_2021.png", "Shahzeb 'ShahZaM' Khan", "USA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
