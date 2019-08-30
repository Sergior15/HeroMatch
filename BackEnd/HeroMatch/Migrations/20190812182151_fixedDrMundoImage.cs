using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class fixedDrMundoImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 61,
                column: "Image",
                value: "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/DrMundo_0.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 61,
                column: "Image",
                value: "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/DrMundo.png");
        }
    }
}
