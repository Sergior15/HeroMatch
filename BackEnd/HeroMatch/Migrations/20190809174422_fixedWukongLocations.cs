using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class fixedWukongLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 57,
                columns: new[] { "ApiLocation", "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/MonkeyKing.json", "https://na.leagueoflegends.com/en/game-info/champions/MonkeyKing/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MonkeyKing_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MonkeyKing.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 57,
                columns: new[] { "ApiLocation", "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Wukong.json", "https://na.leagueoflegends.com/en/game-info/champions/Wukong/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Wukong_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Wukong.png" });
        }
    }
}
