using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class addedSmallImageForCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SmallImage",
                table: "Character",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Download = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Description", "Download", "Image", "Name", "Video" },
                values: new object[] { 1, "Overwatch is a colorful team-based shooter game starring a diverse cast of powerful heroes. Travel the world, build a team, and contest objectives in exhilarating 6v6 combat.", "https://us.shop.battle.net/en-us/product/overwatch?blzcmp=ow_buy_nav", "https://stmed.net/sites/default/files/overwatch-hd-wallpapers-33472-8666477.jpg", "Overwatch", "https://www.youtube.com/watch?v=dushZybUYnM&t=9s" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 6,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 7,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 9,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 17,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 25,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 26,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 30,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                columns: new[] { "Image", "SmallImage" },
                values: new object[] { "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/full-portrait.png", "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Character_GameId",
                table: "Character",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Game_GameId",
                table: "Character",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Game_GameId",
                table: "Character");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Character_GameId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "SmallImage",
                table: "Character");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 6,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 7,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 9,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 17,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 25,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 26,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 30,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png");

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                column: "Image",
                value: "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png");
        }
    }
}
