using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class FixexCapatalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 45,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/LeeSin/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/LeeSin_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/LeeSin.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 46,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/MasterYi/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MasterYi_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MasterYi.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 61,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/DrMundo/", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/DrMundo.png", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/DrMundo.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 93,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/MissFortune/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MissFortune_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MissFortune.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 123,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/AurelionSol/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/AurelionSol_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/AurelionSol.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 145,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/TwistedFate/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TwistedFate_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/TwistedFate.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 162,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/TahmKench/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TahmKench_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/TahmKench.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 45,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Leesin/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leesin_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leesin.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 46,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Masteryi/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Masteryi_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Masteryi.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 61,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Drmundo/", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Drmundo.png", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Drmundo.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 93,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Missfortune/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Missfortune_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Missfortune.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 123,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Aurelionsol/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aurelionsol_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Aurelionsol.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 145,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Twistedfate/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Twistedfate_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Twistedfate.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 162,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/Tahmkench/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tahmkench_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tahmkench.png" });
        }
    }
}
