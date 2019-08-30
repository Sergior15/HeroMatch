using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class AddedGameIDandCharURLtoCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FilterId",
                table: "Character",
                newName: "GameId");

            migrationBuilder.AddColumn<string>(
                name: "CharacterUrl",
                table: "Character",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/reinhardt/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/orisa/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/dva/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/Winston/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/roadhog/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 6,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/wrecking-ball/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 7,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/sigma/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/zarya/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 9,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/ashe/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/mccree/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/hanzo/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/widowmaker/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/soldier-76/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/reaper/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/sombra/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/genji/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 17,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/doomfist/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/tracer/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/torbjorn/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/symmetra/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/pharah/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/mei/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/junkrat/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/bastion/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 25,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/baptiste/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 26,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/brigitte/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/ana/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/lucio/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/mercy/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 30,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/moira/", 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                columns: new[] { "CharacterUrl", "GameId" },
                values: new object[] { "https://playoverwatch.com/en-us/heroes/zenyatta/", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacterUrl",
                table: "Character");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Character",
                newName: "FilterId");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 6,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 7,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 17,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 25,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 26,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 30,
                column: "FilterId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                column: "FilterId",
                value: 0);
        }
    }
}
