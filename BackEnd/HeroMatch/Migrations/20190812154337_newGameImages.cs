using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class newGameImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Image",
                value: "https://1000logos.net/wp-content/uploads/2018/01/overwatch-logo.png");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Image",
                value: "https://www.riotgames.com/darkroom/800/6e3cb0c1ef68c36917c0ebc60e134f69:27e118b555199ad4738eaa74561e3e79/blank-uml-page-2.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Image",
                value: "https://stmed.net/sites/default/files/overwatch-hd-wallpapers-33472-8666477.jpg");

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Image",
                value: "http://mumumaki.com/wp-content/uploads/2018/07/League-Of-Legends-Wallpaper.jpg");
        }
    }
}
