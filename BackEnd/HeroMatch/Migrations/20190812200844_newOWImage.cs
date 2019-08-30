using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class newOWImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Image",
                value: "https://blizzard.gamespress.com/cdn/propressroom/Content/Artwork/Eva/BlizzardLive/artwork/2017/11/02182055-e94a78e3-9eae-4423-a3e8-59ecf50039dd/OW_Logo_Full_White.png?w=1024&maxheight=4096&mode=pad&format=png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Image",
                value: "https://1000logos.net/wp-content/uploads/2018/01/overwatch-logo.png");
        }
    }
}
