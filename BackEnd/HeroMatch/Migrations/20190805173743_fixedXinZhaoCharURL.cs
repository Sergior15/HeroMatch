using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class fixedXinZhaoCharURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 58,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "https://na.leagueoflegends.com/en/game-info/champions/XinZhao/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/XinZhao_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/XinZhao.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 58,
                columns: new[] { "CharacterUrl", "Image", "SmallImage" },
                values: new object[] { "`https://na.leagueoflegends.com/en/game-info/champions/Xinzhao/", "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xinzhao_0.jpg", "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xinzhao.png" });
        }
    }
}
