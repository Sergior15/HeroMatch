using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    FilterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Filter",
                columns: table => new
                {
                    FilterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Difficulty = table.Column<int>(nullable: false),
                    Role = table.Column<int>(nullable: false),
                    SubRole = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filter", x => x.FilterId);
                });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "FilterId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png", "Reinhardt" },
                    { 30, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png", "Moira" },
                    { 29, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png", "Mercy" },
                    { 28, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png", "Lúcio" },
                    { 27, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png", "Ana" },
                    { 26, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png", "Brigitte" },
                    { 25, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png", "Baptiste" },
                    { 24, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png", "Bastion" },
                    { 23, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png", "Junkrat" },
                    { 22, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png", "Mei" },
                    { 21, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png", "Pharah" },
                    { 20, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png", "Symmetra" },
                    { 19, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png", "Torbjörn" },
                    { 18, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png", "Tracer" },
                    { 17, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png", "Doomfist" },
                    { 31, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png", "Zenyatta" },
                    { 15, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png", "Sombra" },
                    { 2, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png", "Orisa" },
                    { 3, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png", "D. Va" },
                    { 4, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png", "Winston" },
                    { 5, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png", "Roadhog" },
                    { 16, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png", "Genji" },
                    { 7, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png", "Sigma" },
                    { 6, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png", "Wrecking Ball" },
                    { 9, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png", "Ashe" },
                    { 10, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png", "McCree" },
                    { 11, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png", "Hanzo" },
                    { 12, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png", "Widowmaker" },
                    { 13, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png", "Soldier: 76" },
                    { 14, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png", "Reaper" },
                    { 8, 0, "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png", "Zarya" }
                });

            migrationBuilder.InsertData(
                table: "Filter",
                columns: new[] { "FilterId", "CharacterId", "Difficulty", "Role", "SubRole" },
                values: new object[,]
                {
                    { 18, 18, 2, 2, 2 },
                    { 19, 19, 2, 2, 3 },
                    { 20, 20, 3, 2, 3 },
                    { 21, 21, 2, 2, 3 },
                    { 22, 22, 2, 2, 3 },
                    { 29, 29, 1, 3, 2 },
                    { 24, 24, 1, 2, 3 },
                    { 25, 25, 2, 3, 1 },
                    { 26, 26, 1, 3, 1 },
                    { 27, 27, 3, 3, 1 },
                    { 28, 28, 2, 3, 2 },
                    { 17, 17, 2, 2, 2 },
                    { 23, 23, 1, 2, 3 },
                    { 16, 16, 3, 2, 2 },
                    { 8, 8, 3, 1, 2 },
                    { 14, 14, 1, 2, 2 },
                    { 13, 13, 1, 2, 1 },
                    { 12, 12, 3, 2, 1 },
                    { 11, 11, 3, 2, 1 },
                    { 10, 10, 2, 2, 1 },
                    { 9, 9, 2, 2, 1 },
                    { 7, 7, 3, 1, 2 },
                    { 6, 6, 2, 1, 2 },
                    { 5, 5, 1, 1, 2 },
                    { 4, 4, 2, 1, 1 },
                    { 3, 3, 3, 1, 1 },
                    { 2, 2, 2, 1, 1 },
                    { 1, 1, 1, 1, 1 },
                    { 30, 30, 2, 3, 2 },
                    { 15, 15, 3, 2, 2 },
                    { 31, 31, 3, 3, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "Filter");
        }
    }
}
