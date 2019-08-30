using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class movedFilterPropertiesToCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Filter",
                keyColumn: "FilterId",
                keyValue: 31);

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubRole",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 2,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 3,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 4,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 5,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 6,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 7,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 8,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 9,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 10,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 11,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 12,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 13,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 14,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 15,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 16,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 17,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 18,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 19,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 20,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 21,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 22,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 23,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 24,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 25,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 26,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 27,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 28,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 29,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 30,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 2, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 31,
                columns: new[] { "Difficulty", "Role", "SubRole" },
                values: new object[] { 3, 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "SubRole",
                table: "Character");

            migrationBuilder.InsertData(
                table: "Filter",
                columns: new[] { "FilterId", "CharacterId", "Difficulty", "Role", "SubRole" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1 },
                    { 29, 29, 1, 3, 2 },
                    { 28, 28, 2, 3, 2 },
                    { 27, 27, 3, 3, 1 },
                    { 26, 26, 1, 3, 1 },
                    { 25, 25, 2, 3, 1 },
                    { 24, 24, 1, 2, 3 },
                    { 23, 23, 1, 2, 3 },
                    { 22, 22, 2, 2, 3 },
                    { 21, 21, 2, 2, 3 },
                    { 20, 20, 3, 2, 3 },
                    { 19, 19, 2, 2, 3 },
                    { 18, 18, 2, 2, 2 },
                    { 17, 17, 2, 2, 2 },
                    { 30, 30, 2, 3, 2 },
                    { 16, 16, 3, 2, 2 },
                    { 14, 14, 1, 2, 2 },
                    { 13, 13, 1, 2, 1 },
                    { 12, 12, 3, 2, 1 },
                    { 11, 11, 3, 2, 1 },
                    { 10, 10, 2, 2, 1 },
                    { 9, 9, 2, 2, 1 },
                    { 8, 8, 3, 1, 2 },
                    { 7, 7, 3, 1, 2 },
                    { 6, 6, 2, 1, 2 },
                    { 5, 5, 1, 1, 2 },
                    { 4, 4, 2, 1, 1 },
                    { 3, 3, 3, 1, 1 },
                    { 2, 2, 2, 1, 1 },
                    { 15, 15, 3, 2, 2 },
                    { 31, 31, 3, 3, 2 }
                });
        }
    }
}
