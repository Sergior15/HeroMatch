using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class OverwatchApiLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApiLocation",
                table: "Character",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/13");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/24");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/3");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/20");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/14");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/21");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/8");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/5");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/19");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/15");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/12");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/23");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/4");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/18");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/17");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/16");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/11");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/9");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/6");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/2");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/1");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/7");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/10");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                column: "ApiLocation",
                value: "https://overwatch-api.net/api/v1/hero/22");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApiLocation",
                table: "Character");
        }
    }
}
