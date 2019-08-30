using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroMatch.Migrations
{
    public partial class LeagueCharacterData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Aesthetic",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Description", "Download", "Image", "Name", "Video" },
                values: new object[] { 2, "League of Legends is a fast-paced, competitive online game that blends the speed and intensity of real time strategy with role playing game elements. Two teams of powerful champions, each with a unique design and playstyle, battle head-to-head across multiple battlefields and game modes. With an ever-expanding roster of champions, frequent updates and a thriving tournament scene, League of Legends offers endless replayability for players of every skill level.", "https://signup.na.leagueoflegends.com/en/signup/index#/", "http://mumumaki.com/wp-content/uploads/2018/07/League-Of-Legends-Wallpaper.jpg", "League of Legends", "https://www.youtube.com/watch?v=-157HBpPZ24" });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "Aesthetic", "CharacterUrl", "Difficulty", "GameId", "Image", "Name", "Role", "SmallImage", "SubRole" },
                values: new object[,]
                {
                    { 32, 2, "https://na.leagueoflegends.com/en/game-info/champions/Aatrox/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_0.jpg", "Aatrox", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Aatrox.png", 2 },
                    { 124, 3, "https://na.leagueoflegends.com/en/game-info/champions/Azir/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_0.jpg", "Azir", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Azir.png", 3 },
                    { 125, 2, "https://na.leagueoflegends.com/en/game-info/champions/Brand/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Brand_0.jpg", "Brand", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Brand.png", 3 },
                    { 126, 3, "https://na.leagueoflegends.com/en/game-info/champions/Cassiopeia/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_0.jpg", "Cassiopeia", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Cassiopeia.png", 3 },
                    { 127, 2, "https://na.leagueoflegends.com/en/game-info/champions/Fiddlesticks/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiddlesticks_0.jpg", "Fiddlesticks", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fiddlesticks.png", 3 },
                    { 128, 1, "https://na.leagueoflegends.com/en/game-info/champions/Gragas/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gragas_0.jpg", "Gragas", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gragas.png", 3 },
                    { 129, 2, "https://na.leagueoflegends.com/en/game-info/champions/Heimerdinger/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Heimerdinger_0.jpg", "Heimerdinger", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Heimerdinger.png", 3 },
                    { 123, 3, "https://na.leagueoflegends.com/en/game-info/champions/Aurelionsol/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aurelionsol_0.jpg", "Aurelion Sol", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Aurelionsol.png", 3 },
                    { 130, 2, "https://na.leagueoflegends.com/en/game-info/champions/Karthus/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karthus_0.jpg", "Karthus", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Karthus.png", 3 },
                    { 132, 3, "https://na.leagueoflegends.com/en/game-info/champions/Kennen/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kennen_0.jpg", "Kennen", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kennen.png", 3 },
                    { 133, 2, "https://na.leagueoflegends.com/en/game-info/champions/Lissandra/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lissandra_0.jpg", "Lissandra", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lissandra.png", 3 },
                    { 134, 1, "https://na.leagueoflegends.com/en/game-info/champions/Lux/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lux_0.jpg", "Lux", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lux.png", 3 },
                    { 135, 2, "https://na.leagueoflegends.com/en/game-info/champions/Malzahar/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malzahar_0.jpg", "Malzahar", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Malzahar.png", 3 },
                    { 136, 1, "https://na.leagueoflegends.com/en/game-info/champions/Neeko/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Neeko_0.jpg", "Neeko", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Neeko.png", 3 },
                    { 137, 2, "https://na.leagueoflegends.com/en/game-info/champions/Orianna/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Orianna_0.jpg", "Orianna", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Orianna.png", 3 },
                    { 131, 1, "https://na.leagueoflegends.com/en/game-info/champions/Kayle/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayle_0.jpg", "Kayle", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kayle.png", 3 },
                    { 138, 2, "https://na.leagueoflegends.com/en/game-info/champions/Rumble/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rumble_0.jpg", "Rumble", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rumble.png", 3 },
                    { 122, 1, "https://na.leagueoflegends.com/en/game-info/champions/Annie/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Annie_0.jpg", "Annie", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Annie.png", 3 },
                    { 120, 3, "https://na.leagueoflegends.com/en/game-info/champions/Ahri/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg", "Ahri", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ahri.png", 3 },
                    { 106, 2, "https://na.leagueoflegends.com/en/game-info/champions/Evelynn/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Evelynn_0.jpg", "Evelynn", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Evelynn.png", 2 },
                    { 107, 3, "https://na.leagueoflegends.com/en/game-info/champions/Fizz/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_0.jpg", "Fizz", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fizz.png", 2 },
                    { 108, 2, "https://na.leagueoflegends.com/en/game-info/champions/Kassadin/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kassadin_0.jpg", "Kassadin", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kassadin.png", 2 },
                    { 109, 1, "https://na.leagueoflegends.com/en/game-info/champions/Katarina/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Katarina_0.jpg", "Katarina", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Katarina.png", 2 },
                    { 110, 2, "https://na.leagueoflegends.com/en/game-info/champions/Kayn/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayn_0.jpg", "Kayn", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kayn.png", 2 },
                    { 111, 3, "https://na.leagueoflegends.com/en/game-info/champions/Khazix/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Khazix_0.jpg", "Kha'Zix", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Khazix.png", 2 },
                    { 121, 3, "https://na.leagueoflegends.com/en/game-info/champions/Anivia/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Anivia_0.jpg", "Anivia", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Anivia.png", 3 },
                    { 112, 1, "https://na.leagueoflegends.com/en/game-info/champions/Leblanc/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leblanc_0.jpg", "LeBlanc", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leblanc.png", 2 },
                    { 114, 3, "https://na.leagueoflegends.com/en/game-info/champions/Nocturne/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nocturne_0.jpg", "Nocturne", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nocturne.png", 2 },
                    { 115, 1, "https://na.leagueoflegends.com/en/game-info/champions/Qiyana/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Qiyana_0.jpg", "Qiyana", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Qiyana.png", 2 },
                    { 116, 3, "https://na.leagueoflegends.com/en/game-info/champions/Rengar/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rengar_0.jpg", "Rengar", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rengar.png", 2 },
                    { 117, 1, "https://na.leagueoflegends.com/en/game-info/champions/Shaco/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shaco_0.jpg", "Shaco", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shaco.png", 2 },
                    { 118, 1, "https://na.leagueoflegends.com/en/game-info/champions/Talon/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Talon_0.jpg", "Talon", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Talon.png", 2 },
                    { 119, 2, "https://na.leagueoflegends.com/en/game-info/champions/Zed/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zed_0.jpg", "Zed", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zed.png", 2 },
                    { 113, 3, "https://na.leagueoflegends.com/en/game-info/champions/Nidalee/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nidalee_0.jpg", "Nidalee", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nidalee.png", 2 },
                    { 105, 3, "https://na.leagueoflegends.com/en/game-info/champions/Elise/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Elise_0.jpg", "Elise", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Elise.png", 2 },
                    { 139, 2, "https://na.leagueoflegends.com/en/game-info/champions/Ryze/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ryze_0.jpg", "Ryze", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ryze.png", 3 },
                    { 141, 1, "https://na.leagueoflegends.com/en/game-info/champions/Sylas/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sylas_0.jpg", "Sylas", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sylas.png", 3 },
                    { 160, 2, "https://na.leagueoflegends.com/en/game-info/champions/Nautilus/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nautilus_0.jpg", "Nautilus", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nautilus.png", 1 },
                    { 161, 1, "https://na.leagueoflegends.com/en/game-info/champions/Pyke/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pyke_0.jpg", "Pyke", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Pyke.png", 1 },
                    { 162, 3, "https://na.leagueoflegends.com/en/game-info/champions/Tahmkench/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tahmkench_0.jpg", "Tahm Kench", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tahmkench.png", 1 },
                    { 163, 2, "https://na.leagueoflegends.com/en/game-info/champions/Thresh", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg", "Thresh", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Thresh.png", 1 },
                    { 164, 3, "https://na.leagueoflegends.com/en/game-info/champions/Velkoz/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Velkoz_0.jpg", "Vel'Koz", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Velkoz.png", 1 },
                    { 165, 1, "https://na.leagueoflegends.com/en/game-info/champions/Zilean/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg", "Zilean", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zilean.png", 1 },
                    { 159, 1, "https://na.leagueoflegends.com/en/game-info/champions/Morgana/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Morgana_0.jpg", "Morgana", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Morgana.png", 1 },
                    { 166, 1, "https://na.leagueoflegends.com/en/game-info/champions/Zyra/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zyra_0.jpg", "Zyra", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zyra.png", 1 },
                    { 168, 2, "https://na.leagueoflegends.com/en/game-info/champions/Janna/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Janna_0.jpg", "Janna", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Janna.png", 2 },
                    { 169, 2, "https://na.leagueoflegends.com/en/game-info/champions/Lulu/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lulu_0.jpg", "Lulu", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lulu.png", 2 },
                    { 170, 3, "https://na.leagueoflegends.com/en/game-info/champions/Nami/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nami_0.jpg", "Nami", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nami.png", 2 },
                    { 171, 1, "https://na.leagueoflegends.com/en/game-info/champions/Rakan/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rakan_0.jpg", "Rakan", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rakan.png", 2 },
                    { 172, 1, "https://na.leagueoflegends.com/en/game-info/champions/Sona/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_0.jpg", "Sona", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sona.png", 2 },
                    { 173, 3, "https://na.leagueoflegends.com/en/game-info/champions/Soraka/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Soraka_0.jpg", "Soraka", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Soraka.png", 2 },
                    { 167, 2, "https://na.leagueoflegends.com/en/game-info/champions/Ivern/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ivern_0.jpg", "Ivern", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ivern.png", 2 },
                    { 140, 3, "https://na.leagueoflegends.com/en/game-info/champions/Swain/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Swain_0.jpg", "Swain", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Swain.png", 3 },
                    { 158, 1, "https://na.leagueoflegends.com/en/game-info/champions/Leona/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leona_0.jpg", "Leona", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leona.png", 1 },
                    { 156, 2, "https://na.leagueoflegends.com/en/game-info/champions/Galio/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_0.jpg", "Galio", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Galio.png", 1 },
                    { 142, 1, "https://na.leagueoflegends.com/en/game-info/champions/Syndra/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Syndra_0.jpg", "Syndra", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Syndra.png", 3 },
                    { 143, 1, "https://na.leagueoflegends.com/en/game-info/champions/Taliyah/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taliyah_0.jpg", "Taliyah", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Taliyah.png", 3 },
                    { 144, 3, "https://na.leagueoflegends.com/en/game-info/champions/Teemo/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg", "Teemo", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Teemo.png", 3 },
                    { 145, 1, "https://na.leagueoflegends.com/en/game-info/champions/Twistedfate/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Twistedfate_0.jpg", "Twisted Fate", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Twistedfate.png", 3 },
                    { 146, 1, "https://na.leagueoflegends.com/en/game-info/champions/Veigar/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Veigar_0.jpg", "Veigar", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Veigar.png", 3 },
                    { 147, 2, "https://na.leagueoflegends.com/en/game-info/champions/Viktor/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Viktor_0.jpg", "Viktor", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Viktor.png", 3 },
                    { 157, 1, "https://na.leagueoflegends.com/en/game-info/champions/Karma/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karma_0.jpg", "Karma", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Karma.png", 1 },
                    { 148, 2, "https://na.leagueoflegends.com/en/game-info/champions/Vladimir/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vladimir_0.jpg", "Vladimir", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vladimir.png", 3 },
                    { 150, 3, "https://na.leagueoflegends.com/en/game-info/champions/Ziggs/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ziggs_0.jpg", "Ziggs", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ziggs.png", 3 },
                    { 151, 1, "https://na.leagueoflegends.com/en/game-info/champions/Zoe/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zoe_0.jpg", "Zoe", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zoe.png", 3 },
                    { 152, 2, "https://na.leagueoflegends.com/en/game-info/champions/Bard/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Bard_0.jpg", "Bard", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Bard.png", 1 },
                    { 153, 3, "https://na.leagueoflegends.com/en/game-info/champions/Alistar/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Alistar_0.jpg", "Alistar", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Alistar.png", 1 },
                    { 154, 2, "https://na.leagueoflegends.com/en/game-info/champions/Blitzcrank/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Blitzcrank_0.jpg", "Blitzcrank", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Blitzcrank.png", 1 },
                    { 155, 1, "https://na.leagueoflegends.com/en/game-info/champions/Braum/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Braum_0.jpg", "Braum", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Braum.png", 1 },
                    { 149, 2, "https://na.leagueoflegends.com/en/game-info/champions/Xerath/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xerath_0.jpg", "Xerath", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xerath.png", 3 },
                    { 104, 1, "https://na.leagueoflegends.com/en/game-info/champions/Ekko/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_0.jpg", "Ekko", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ekko.png", 2 },
                    { 103, 1, "https://na.leagueoflegends.com/en/game-info/champions/Diana/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Diana_0.jpg", "Diana", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Diana.png", 2 },
                    { 102, 1, "https://na.leagueoflegends.com/en/game-info/champions/Akali/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_0.jpg", "Akali", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Akali.png", 2 },
                    { 51, 3, "https://na.leagueoflegends.com/en/game-info/champions/Renekton/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Renekton_0.jpg", "Renekton", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Renekton.png", 2 },
                    { 52, 3, "https://na.leagueoflegends.com/en/game-info/champions/Shyvana/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shyvana_0.jpg", "Shyvana", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shyvana.png", 2 },
                    { 53, 1, "https://na.leagueoflegends.com/en/game-info/champions/Singed/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Singed_0.jpg", "Singed", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Singed.png", 2 },
                    { 54, 1, "https://na.leagueoflegends.com/en/game-info/champions/Tryndamere/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tryndamere_0.jpg", "Tryndamere", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tryndamere.png", 2 },
                    { 55, 2, "https://na.leagueoflegends.com/en/game-info/champions/Urgot/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Urgot_0.jpg", "Urgot", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Urgot.png", 2 },
                    { 56, 1, "https://na.leagueoflegends.com/en/game-info/champions/Vi/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vi_0.jpg", "Vi", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vi.png", 2 },
                    { 50, 3, "https://na.leagueoflegends.com/en/game-info/champions/Reksai/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Reksai_0.jpg", "Rek'Sai", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Reksai.png", 2 },
                    { 57, 3, "https://na.leagueoflegends.com/en/game-info/champions/Wukong/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Wukong_0.jpg", "Wukong", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Wukong.png", 2 },
                    { 59, 2, "https://na.leagueoflegends.com/en/game-info/champions/Yorick/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yorick_0.jpg", "Yorick", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yorick.png", 2 },
                    { 60, 2, "https://na.leagueoflegends.com/en/game-info/champions/Amumu/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Amumu_0.jpg", "Amumu", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Amumu.png", 1 },
                    { 61, 2, "https://na.leagueoflegends.com/en/game-info/champions/Drmundo/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Drmundo.png", "Dr. Mundo", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Drmundo.png", 1 },
                    { 62, 1, "https://na.leagueoflegends.com/en/game-info/champions/JarvanIV/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/JarvanIV_0.jpg", "Jarvan IV", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/JarvanIV.png", 1 },
                    { 63, 2, "https://na.leagueoflegends.com/en/game-info/champions/Malphite/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malphite_0.jpg", "Malphite", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Malphite.png", 1 },
                    { 64, 2, "https://na.leagueoflegends.com/en/game-info/champions/Maokai/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Maokai_0.jpg", "Maokai", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Maokai.png", 1 },
                    { 58, 1, "`https://na.leagueoflegends.com/en/game-info/champions/Xinzhao/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xinzhao_0.jpg", "Xin Zhao", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xinzhao.png", 2 },
                    { 65, 3, "https://na.leagueoflegends.com/en/game-info/champions/Nasus/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nasus_0.jpg", "Nasus", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nasus.png", 1 },
                    { 49, 1, "https://na.leagueoflegends.com/en/game-info/champions/Pantheon/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pantheon_0.jpg", "Pantheon", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Pantheon.png", 2 },
                    { 47, 2, "https://na.leagueoflegends.com/en/game-info/champions/Mordekaiser/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Mordekaiser_0.jpg", "Mordekaiser", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Mordekaiser.png", 2 },
                    { 33, 1, "https://na.leagueoflegends.com/en/game-info/champions/Camille/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Camille_0.jpg", "Camille", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Camille.png", 2 },
                    { 34, 3, "https://na.leagueoflegends.com/en/game-info/champions/Chogath/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Chogath_0.jpg", "Cho'Gath", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Chogath.png", 2 },
                    { 35, 1, "https://na.leagueoflegends.com/en/game-info/champions/Darius/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_0.jpg", "Darius", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Darius.png", 2 },
                    { 36, 1, "https://na.leagueoflegends.com/en/game-info/champions/Fiora/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiora_0.jpg", "Fiora", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fiora.png", 2 },
                    { 37, 2, "https://na.leagueoflegends.com/en/game-info/champions/Gangplank/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gangplank_0.jpg", "Gangplank", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gangplank.png", 2 },
                    { 38, 1, "https://na.leagueoflegends.com/en/game-info/champions/Garen/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Garen_0.jpg", "Garen", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Garen.png", 2 },
                    { 48, 1, "https://na.leagueoflegends.com/en/game-info/champions/Olaf/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Olaf_0.jpg", "Olaf", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Olaf.png", 2 },
                    { 39, 3, "https://na.leagueoflegends.com/en/game-info/champions/Gnar/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gnar_0.jpg", "Gnar", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gnar.png", 2 },
                    { 41, 2, "https://na.leagueoflegends.com/en/game-info/champions/Illaoi/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Illaoi_0.jpg", "Illaoi", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Illaoi.png", 2 },
                    { 42, 1, "https://na.leagueoflegends.com/en/game-info/champions/Irelia/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Irelia_0.jpg", "Irelia", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Irelia.png", 2 },
                    { 43, 2, "https://na.leagueoflegends.com/en/game-info/champions/Jax/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jax_0.jpg", "Jax", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jax.png", 2 },
                    { 44, 3, "https://na.leagueoflegends.com/en/game-info/champions/Kled/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kled_0.jpg", "Kled", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kled.png", 2 },
                    { 45, 1, "https://na.leagueoflegends.com/en/game-info/champions/Leesin/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leesin_0.jpg", "Lee Sin", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leesin.png", 2 },
                    { 46, 1, "https://na.leagueoflegends.com/en/game-info/champions/Masteryi/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Masteryi_0.jpg", "Master Yi", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Masteryi.png", 2 },
                    { 40, 3, "https://na.leagueoflegends.com/en/game-info/champions/Hecarim/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Hecarim_0.jpg", "Hecarim", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Hecarim.png", 2 },
                    { 66, 1, "https://na.leagueoflegends.com/en/game-info/champions/Nunu/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nunu_0.jpg", "Nunu & Willump", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nunu.png", 1 },
                    { 67, 2, "https://na.leagueoflegends.com/en/game-info/champions/Ornn/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ornn_0.jpg", "Ornn", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ornn.png", 1 },
                    { 68, 1, "https://na.leagueoflegends.com/en/game-info/champions/Poppy/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Poppy_0.jpg", "Poppy", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Poppy.png", 1 },
                    { 87, 2, "https://na.leagueoflegends.com/en/game-info/champions/Kaisa/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kaisa_0.jpg", "Kai'Sa", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kaisa.png", 1 },
                    { 88, 2, "https://na.leagueoflegends.com/en/game-info/champions/Kalista/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kalista_0.jpg", "Kalista", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kalista.png", 1 },
                    { 89, 3, "https://na.leagueoflegends.com/en/game-info/champions/Kindred/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kindred_0.jpg", "Kindred", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kindred.png", 1 },
                    { 91, 3, "https://na.leagueoflegends.com/en/game-info/champions/Kogmaw/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kogmaw_0.jpg", "Kog'Maw", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kogmaw.png", 1 },
                    { 92, 1, "https://na.leagueoflegends.com/en/game-info/champions/Lucian/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lucian_0.jpg", "Lucian", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lucian.png", 1 },
                    { 93, 1, "https://na.leagueoflegends.com/en/game-info/champions/Missfortune/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Missfortune_0.jpg", "Miss Fortune", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Missfortune.png", 1 },
                    { 86, 3, "https://na.leagueoflegends.com/en/game-info/champions/Jinx/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jinx_0.jpg", "Jinx", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jinx.png", 1 },
                    { 94, 1, "https://na.leagueoflegends.com/en/game-info/champions/Quinn/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Quinn_0.jpg", "Quinn", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Quinn.png", 1 },
                    { 96, 2, "https://na.leagueoflegends.com/en/game-info/champions/Tristana/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tristana_0.jpg", "Tristana", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tristana.png", 1 },
                    { 97, 3, "https://na.leagueoflegends.com/en/game-info/champions/Twitch/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Twitch_0.jpg", "Twitch", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Twitch.png", 1 },
                    { 98, 2, "https://na.leagueoflegends.com/en/game-info/champions/Varus/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Varus_0.jpg", "Varus", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Varus.png", 1 },
                    { 99, 1, "https://na.leagueoflegends.com/en/game-info/champions/Vayne/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vayne_0.jpg", "Vayne", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vayne.png", 1 },
                    { 100, 3, "https://na.leagueoflegends.com/en/game-info/champions/Xayah/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xayah_0.jpg", "Xayah", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xayah.png", 1 },
                    { 101, 1, "https://na.leagueoflegends.com/en/game-info/champions/Yasuo/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yasuo_0.jpg", "Yasuo", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yasuo.png", 1 },
                    { 95, 3, "https://na.leagueoflegends.com/en/game-info/champions/Sivir/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sivir_0.jpg", "Sivir", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sivir.png", 1 },
                    { 85, 1, "https://na.leagueoflegends.com/en/game-info/champions/Jhin/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jhin_0.jpg", "Jhin", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jhin.png", 1 },
                    { 84, 1, "https://na.leagueoflegends.com/en/game-info/champions/Jayce/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jayce_0.jpg", "Jayce", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jayce.png", 1 },
                    { 90, 1, "https://na.leagueoflegends.com/en/game-info/champions/Graves/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Graves_0.jpg", "Graves", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Graves.png", 1 },
                    { 69, 3, "https://na.leagueoflegends.com/en/game-info/champions/Rammus/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rammus_0.jpg", "Rammus", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rammus.png", 1 },
                    { 70, 2, "https://na.leagueoflegends.com/en/game-info/champions/Sejuani/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sejuani_0.jpg", "Sejuani", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sejuani.png", 1 },
                    { 71, 1, "https://na.leagueoflegends.com/en/game-info/champions/Shen/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shen_0.jpg", "Shen", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shen.png", 1 },
                    { 72, 2, "https://na.leagueoflegends.com/en/game-info/champions/Sion/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sion_0.jpg", "Sion", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sion.png", 1 },
                    { 73, 3, "https://na.leagueoflegends.com/en/game-info/champions/Skarner/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Skarner_0.jpg", "Skarner", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Skarner.png", 1 },
                    { 74, 2, "https://na.leagueoflegends.com/en/game-info/champions/Trundle/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Trundle_0.jpg", "Trundle", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Trundle.png", 1 },
                    { 75, 3, "https://na.leagueoflegends.com/en/game-info/champions/Udyr/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Udyr_0.jpg", "Udyr", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Udyr.png", 1 },
                    { 76, 3, "https://na.leagueoflegends.com/en/game-info/champions/Volibear/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Volibear_0.jpg", "Volibear", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Volibear.png", 1 },
                    { 77, 3, "https://na.leagueoflegends.com/en/game-info/champions/Warwick/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Warwick_0.jpg", "Warwick", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Warwick.png", 1 },
                    { 78, 2, "https://na.leagueoflegends.com/en/game-info/champions/Zac/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zac_0.jpg", "Zac", 1, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zac.png", 1 },
                    { 79, 1, "https://na.leagueoflegends.com/en/game-info/champions/Ashe/", 1, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_0.jpg", "Ashe", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ashe.png", 1 },
                    { 80, 1, "https://na.leagueoflegends.com/en/game-info/champions/Caitlyn/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Caitlyn_0.jpg", "Caitlyn", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Caitlyn.png", 1 },
                    { 81, 2, "https://na.leagueoflegends.com/en/game-info/champions/Corki/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_0.jpg", "Corki", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Corki.png", 1 },
                    { 82, 1, "https://na.leagueoflegends.com/en/game-info/champions/Draven/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Draven_0.jpg", "Draven", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Draven.png", 1 },
                    { 83, 1, "https://na.leagueoflegends.com/en/game-info/champions/Ezreal/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ezreal_0.jpg", "Ezreal", 2, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ezreal.png", 1 },
                    { 174, 1, "https://na.leagueoflegends.com/en/game-info/champions/Taric/", 2, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taric_0.jpg", "Taric", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Taric.png", 2 },
                    { 175, 3, "https://na.leagueoflegends.com/en/game-info/champions/Yuumi/", 3, 2, "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yuumi_0.jpg", "Yuumi", 3, "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yuumi.png", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Aesthetic",
                table: "Character");
        }
    }
}
