using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class fixedLOLVideoLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Video",
                value: "BGtROJeMPeE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Video",
                value: "-157HBpPZ24");
        }
    }
}
