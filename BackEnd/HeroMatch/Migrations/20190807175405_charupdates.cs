using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class charupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 50,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/RekSai/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/RekSai_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/RekSai.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 91,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/KogMaw/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/KogMaw_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/KogMaw.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 50,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Reksai/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Reksai_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Reksai.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 91,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Kogmaw/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kogmaw_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kogmaw.png" });
        }
    }
}
