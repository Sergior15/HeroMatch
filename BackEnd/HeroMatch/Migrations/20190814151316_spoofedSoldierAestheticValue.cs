using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class spoofedSoldierAestheticValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "Aesthetic",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "Aesthetic",
                value: 0);
        }
    }
}
