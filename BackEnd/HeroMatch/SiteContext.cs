﻿using HeroMatch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroMatch
{
    public class SiteContext : DbContext
    {
        public DbSet<Character> Character { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Filter> Filter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=HeroMatch;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasData(
                new Character
                {
                    GameId = 1,
                    CharacterId = 1,
                    Name = "Reinhardt",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/reinhardt/",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/13"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 2,
                    Name = "Orisa",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/orisa/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/24"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 3,
                    Name = "D. Va",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/dva/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/3"
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 4,
                    Name = "Winston",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/Winston/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/20"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 5,
                    Name = "Roadhog",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/roadhog/",
                    Difficulty = 1,
                    Role = 1,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/14"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 6,
                    Name = "Wrecking Ball",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/wrecking-ball/",
                    Difficulty = 2,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 7,
                    Name = "Sigma",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/sigma/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 8,
                    Name = "Zarya",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/zarya/",
                    Difficulty = 3,
                    Role = 1,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/21"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 9,
                    Name = "Ashe",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/ashe/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 10,
                    Name = "McCree",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mccree/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/8"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 11,
                    Name = "Hanzo",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/hanzo/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/5"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 12,
                    Name = "Widowmaker",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/widowmaker/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/19"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 13,
                    Name = "Soldier: 76",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/soldier-76/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/15"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 14,
                    Name = "Reaper",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/reaper/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/12"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 15,
                    Name = "Sombra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/sombra/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/23"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 16,
                    Name = "Genji",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/genji/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/4"
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 17,
                    Name = "Doomfist",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/doomfist/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 18,
                    Name = "Tracer",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/tracer/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/18"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 19,
                    Name = "Torbjörn",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/torbjorn/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/17"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 20,
                    Name = "Symmetra",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/symmetra/",
                    Difficulty = 3,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/16"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 21,
                    Name = "Pharah",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/pharah/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/11"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 22,
                    Name = "Mei",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mei/",
                    Difficulty = 2,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/9"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 23,
                    Name = "Junkrat",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/junkrat/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/6"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 24,
                    Name = "Bastion",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/bastion/",
                    Difficulty = 1,
                    Role = 2,
                    SubRole = 3,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/2"
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 25,
                    Name = "Baptiste",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/baptiste/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 1
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 26,
                    Name = "Brigitte",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/brigitte/",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 1,
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 27,
                    Name = "Ana",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/ana/",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 1,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/1"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 28,
                    Name = "Lúcio",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/lucio/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/7"


                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 29,
                    Name = "Mercy",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/mercy/",
                    Difficulty = 1,
                    Role = 3,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/10"

                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 30,
                    Name = "Moira",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/moira/",
                    Difficulty = 2,
                    Role = 3,
                    SubRole = 2
                },
                new Character
                {
                    GameId = 1,
                    CharacterId = 31,
                    Name = "Zenyatta",
                    Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/full-portrait.png",
                    SmallImage = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png",
                    CharacterUrl = "https://playoverwatch.com/en-us/heroes/zenyatta/",
                    Difficulty = 3,
                    Role = 3,
                    SubRole = 2,
                    ApiLocation = "https://overwatch-api.net/api/v1/hero/22"

                },
                
            new Character
            {
                GameId = 2,
                CharacterId = 32 ,
                Name = "Aatrox",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Aatrox_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Aatrox.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Aatrox/",
                Difficulty = 2, 
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Aatrox.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 33,
                Name = "Camille",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Camille_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Camille.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Camille/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Camille.json"

            },
             new Character
             {
                GameId = 2,
                CharacterId = 34,
                Name = "Cho'Gath",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Chogath_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Chogath.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Chogath/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                 ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Chogath.json"

             },
            new Character
            {
                GameId = 2,
                CharacterId = 35,
                Name = "Darius",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Darius_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Darius.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Darius/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Darius.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 36,
                Name = "Fiora",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiora_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fiora.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Fiora/",
                Difficulty = 3,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Fiora.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 37,
                Name = "Gangplank",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gangplank_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gangplank.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Gangplank/",
                Difficulty = 3,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Gangplank.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 38,
                Name = "Garen",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Garen_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Garen.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Garen/",
                Difficulty = 1,
                Role = 1,
                SubRole =2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Garen.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 39,
                Name = "Gnar",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gnar_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gnar.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Gnar/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Gnar.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 40,
                Name = "Hecarim",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Hecarim_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Hecarim.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Hecarim/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Hecarim.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 41,
                Name = "Illaoi",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Illaoi_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Illaoi.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Illaoi/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Illaoi.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 42,
                Name = "Irelia",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Irelia_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Irelia.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Irelia/",
                Difficulty = 3,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Irelia.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 43,
                Name = "Jax",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jax_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jax.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Jax/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Jax.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 44,
                Name = "Kled",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kled_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kled.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kled/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kled.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 45,
                Name = "Lee Sin",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/LeeSin_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/LeeSin.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/LeeSin/",
                Difficulty = 3,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/LeeSin.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 46,
                Name = "Master Yi",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MasterYi_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MasterYi.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/MasterYi/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/MasterYi.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 47,
                Name = "Mordekaiser",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Mordekaiser_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Mordekaiser.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Mordekaiser/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Mordekaiser.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 48,
                Name = "Olaf",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Olaf_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Olaf.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Olaf/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Olaf.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 49,
                Name = "Pantheon",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pantheon_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Pantheon.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Pantheon/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Pantheon.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 50,
                Name = "Rek'Sai",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/RekSai_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/RekSai.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/RekSai/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/RekSai.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 51,
                Name = "Renekton",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Renekton_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Renekton.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Renekton/",
                Difficulty = 3,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Renekton.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 52,
                Name = "Shyvana",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shyvana_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shyvana.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Shyvana/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Shyvana.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 53,
                Name = "Singed",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Singed_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Singed.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Singed/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Singed.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 54,
                Name = "Tryndamere",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tryndamere_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tryndamere.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Tryndamere/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Tryndamere.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 55,
                Name = "Urgot",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Urgot_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Urgot.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Urgot/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Urgot.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 56,
                Name = "Vi",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vi_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vi.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Vi/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Vi.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 57,
                Name = "Wukong",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MonkeyKing_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MonkeyKing.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/MonkeyKing/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/MonkeyKing.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 58,
                Name = "Xin Zhao",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/XinZhao_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/XinZhao.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/XinZhao/",
                Difficulty = 1,
                Role = 1,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/XinZhao.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 59,
                Name = "Yorick",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yorick_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yorick.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Yorick/",
                Difficulty = 2,
                Role = 1,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Yorick.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 60,
                Name = "Amumu",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Amumu_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Amumu.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Amumu/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Amumu.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 61,
                Name = "Dr. Mundo",
                Image = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/DrMundo.png",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/DrMundo.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/DrMundo/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/DrMundo.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 62,
                Name = "Jarvan IV",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/JarvanIV_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/JarvanIV.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/JarvanIV/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/JarvanIV.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 63,
                Name = "Malphite",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malphite_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Malphite.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Malphite/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Malphite.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 64,
                Name = "Maokai",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Maokai_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Maokai.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Maokai/",
                Difficulty = 3,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Maokai.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 65,
                Name = "Nasus",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nasus_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nasus.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nasus/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nasus.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 66,
                Name = "Nunu & Willump",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nunu_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nunu.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nunu/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nunu.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 67,
                Name = "Ornn",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ornn_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ornn.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ornn/",
                Difficulty = 3,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ornn.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 68,
                Name = "Poppy",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Poppy_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Poppy.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Poppy/",
                Difficulty = 3,
                Role = 1,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Poppy.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 69,
                Name = "Rammus",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rammus_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rammus.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Rammus/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Rammus.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 70,
                Name = "Sejuani",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sejuani_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sejuani.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Sejuani/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Sejuani.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 71,
                Name = "Shen",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shen_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shen.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Shen/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Shen.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 72,
                Name = "Sion",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sion_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sion.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Sion/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Sion.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 73,
                Name = "Skarner",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Skarner_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Skarner.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Skarner/",
                Difficulty = 3,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Skarner.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 74,
                Name = "Trundle",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Trundle_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Trundle.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Trundle/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Trundle.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 75,
                Name = "Udyr",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Udyr_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Udyr.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Udyr/",
                Difficulty = 2,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Udyr.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 76,
                Name = "Volibear",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Volibear_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Volibear.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Volibear/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Volibear.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 77,
                Name = "Warwick",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Warwick_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Warwick.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Warwick/",
                Difficulty = 1,
                Role = 1,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Warwick.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 78,
                Name = "Zac",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zac_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zac.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Zac/",
                Difficulty = 3,
                Role = 1,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Zac.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 79,
                Name = "Ashe",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ashe_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ashe.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ashe/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ashe.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 80,
                Name = "Caitlyn",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Caitlyn_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Caitlyn.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Caitlyn/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Caitlyn.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 81,
                Name = "Corki",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Corki_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Corki.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Corki/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Corki.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 82,
                Name = "Draven",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Draven_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Draven.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Draven/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Draven.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 83,
                Name = "Ezreal",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ezreal_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ezreal.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ezreal/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ezreal.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 90,
                Name = "Graves",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Graves_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Graves.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Graves/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Graves.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 84,
                Name = "Jayce",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jayce_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jayce.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Jayce/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Jayce.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 85,
                Name = "Jhin",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jhin_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jhin.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Jhin/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Jhin.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 86,
                Name = "Jinx",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Jinx_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Jinx.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Jinx/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Jinx.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 87,
                Name = "Kai'Sa",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kaisa_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kaisa.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kaisa/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kaisa.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 88,
                Name = "Kalista",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kalista_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kalista.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kalista/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kalista.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 89,
                Name = "Kindred",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kindred_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kindred.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kindred/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kindred.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 91,
                Name = "Kog'Maw",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/KogMaw_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/KogMaw.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/KogMaw/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/KogMaw.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 92,
                Name = "Lucian",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lucian_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lucian.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Lucian/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Lucian.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 93,
                Name = "Miss Fortune",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/MissFortune_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/MissFortune.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/MissFortune/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/MissFortune.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 94,
                Name = "Quinn",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Quinn_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Quinn.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Quinn/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Quinn.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 95,
                Name = "Sivir",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sivir_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sivir.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Sivir/",
                Difficulty = 2,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Sivir.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 96,
                Name = "Tristana",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Tristana_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Tristana.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Tristana/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Tristana.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 97,
                Name = "Twitch",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Twitch_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Twitch.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Twitch/",
                Difficulty = 1,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Twitch.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 98,
                Name = "Varus",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Varus_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Varus.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Varus/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Varus.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 99,
                Name = "Vayne",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vayne_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vayne.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Vayne/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Vayne.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 100,
                Name = "Xayah",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xayah_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xayah.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Xayah/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Xayah.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 101,
                Name = "Yasuo",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yasuo_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yasuo.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Yasuo/",
                Difficulty = 3,
                Role = 2,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Yasuo.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 102,
                Name = "Akali",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Akali_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Akali.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Akali/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Akali.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 103,
                Name = "Diana",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Diana_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Diana.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Diana/",
                Difficulty = 1,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Diana.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 104,
                Name = "Ekko",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ekko_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ekko.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ekko/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ekko.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 105,
                Name = "Elise",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Elise_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Elise.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Elise/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Elise.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 106,
                Name = "Evelynn",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Evelynn_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Evelynn.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Evelynn/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Evelynn.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 107,
                Name = "Fizz",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fizz_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fizz.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Fizz/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Fizz.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 108,
                Name = "Kassadin",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kassadin_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kassadin.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kassadin/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kassadin.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 109,
                Name = "Katarina",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Katarina_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Katarina.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Katarina/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Katarina.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 110,
                Name = "Kayn",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayn_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kayn.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kayn/",
                Difficulty = 1,
                Role = 2,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kayn.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 111,
                Name = "Kha'Zix",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Khazix_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Khazix.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Khazix/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Khazix.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 112,
                Name = "LeBlanc",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leblanc_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leblanc.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Leblanc/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Leblanc.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 113,
                Name = "Nidalee",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nidalee_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nidalee.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nidalee/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nidalee.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 114,
                Name = "Nocturne",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nocturne_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nocturne.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nocturne/",
                Difficulty = 1,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nocturne.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 115,
                Name = "Qiyana",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Qiyana_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Qiyana.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Qiyana/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Qiyana.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 116,
                Name = "Rengar",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rengar_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rengar.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Rengar/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Rengar.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 117,
                Name = "Shaco",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Shaco_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Shaco.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Shaco/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Shaco.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 118,
                Name = "Talon",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Talon_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Talon.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Talon/",
                Difficulty = 2,
                Role = 2,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Talon.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 119,
                Name = "Zed",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zed_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zed.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Zed/",
                Difficulty = 3,
                Role = 2,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Zed.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 120,
                Name = "Ahri",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ahri_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ahri.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ahri/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ahri.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 121,
                Name = "Anivia",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Anivia_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Anivia.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Anivia/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Anivia.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 122,
                Name = "Annie",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Annie_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Annie.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Annie/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Annie.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 123,
                Name = "Aurelion Sol",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/AurelionSol_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/AurelionSol.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/AurelionSol/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/AurelionSol.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 124,
                Name = "Azir",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Azir_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Azir.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Azir/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Azir.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 125,
                Name = "Brand",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Brand_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Brand.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Brand/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Brand.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 126,
                Name = "Cassiopeia",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Cassiopeia_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Cassiopeia.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Cassiopeia/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3, 
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Cassiopeia.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 127,
                Name = "Fiddlesticks",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Fiddlesticks_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Fiddlesticks.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Fiddlesticks/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Fiddlesticks.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 128,
                Name = "Gragas",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Gragas_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Gragas.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Gragas/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Gragas.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 129,
                Name = "Heimerdinger",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Heimerdinger_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Heimerdinger.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Heimerdinger/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Heimerdinger.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 130,
                Name = "Karthus",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karthus_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Karthus.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Karthus/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Karthus.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 131,
                Name = "Kayle",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kayle_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kayle.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kayle/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kayle.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 132,
                Name = "Kennen",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Kennen_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Kennen.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Kennen/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Kennen.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 133,
                Name = "Lissandra",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lissandra_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lissandra.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Lissandra/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Lissandra.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 134,
                Name = "Lux",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lux_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lux.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Lux/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Lux.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 135,
                Name = "Malzahar",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Malzahar_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Malzahar.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Malzahar/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Malzahar.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 136,
                Name = "Neeko",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Neeko_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Neeko.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Neeko/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Neeko.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 137,
                Name = "Orianna",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Orianna_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Orianna.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Orianna/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Orianna.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 138,
                Name = "Rumble",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rumble_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rumble.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Rumble/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Rumble.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 139,
                Name = "Ryze",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ryze_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ryze.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ryze/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ryze.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 140,
                Name = "Swain",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Swain_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Swain.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Swain/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Swain.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 141,
                Name = "Sylas",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sylas_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sylas.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Sylas/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Sylas.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 142,
                Name = "Syndra",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Syndra_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Syndra.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Syndra/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Syndra.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 143,
                Name = "Taliyah",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taliyah_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Taliyah.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Taliyah/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Taliyah.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 144,
                Name = "Teemo",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Teemo_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Teemo.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Teemo/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Teemo.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 145,
                Name = "Twisted Fate",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TwistedFate_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/TwistedFate.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/TwistedFate/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/TwistedFate.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 146,
                Name = "Veigar",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Veigar_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Veigar.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Veigar/",
                Difficulty = 2,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Veigar.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 147,
                Name = "Viktor",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Viktor_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Viktor.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Viktor/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic  = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Viktor.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 148,
                Name = "Vladimir",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Vladimir_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Vladimir.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Vladimir/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Vladimir.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 149,
                Name = "Xerath",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Xerath_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Xerath.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Xerath/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Xerath.json"

            },
            new Character
            {
                GameId = 2,
                CharacterId = 150,
                Name = "Ziggs",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ziggs_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ziggs.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ziggs/",
                Difficulty = 1,
                Role = 2,
                SubRole = 3,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ziggs.json"

            },
            new Character
            {
                GameId = 2, 
                CharacterId = 151,
                Name = "Zoe" ,
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zoe_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zoe.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Zoe/",
                Difficulty = 3,
                Role = 2,
                SubRole = 3,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Zoe.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 152,
                Name = "Bard",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Bard_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Bard.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Bard/",
                Difficulty = 2,
                Role = 3,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Bard.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 153,
                Name = "Alistar",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Alistar_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Alistar.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Alistar/",
                Difficulty = 2,
                Role = 3,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Alistar.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 154,
                Name = "Blitzcrank",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Blitzcrank_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Blitzcrank.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Blitzcrank/",
                Difficulty = 1,
                Role = 3,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Blitzcrank.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 155,
                Name = "Braum",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Braum_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Braum.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Braum/",
                Difficulty = 2,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Braum.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 156,
                Name = "Galio",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Galio_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Galio.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Galio/",
                Difficulty = 3,
                Role = 3,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Galio.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 157,
                Name = "Karma",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Karma_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Karma.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Karma/",
                Difficulty = 2,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Karma.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 158,
                Name = "Leona",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Leona_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Leona.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Leona/",
                Difficulty = 1,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Leona.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 159,
                Name = "Morgana",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Morgana_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Morgana.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Morgana/",
                Difficulty = 3,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Morgana.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 160,
                Name = "Nautilus",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nautilus_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nautilus.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nautilus/",
                Difficulty = 1,
                Role = 3,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nautilus.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 161,
                Name = "Pyke",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Pyke_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Pyke.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Pyke/",
                Difficulty = 3,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Pyke.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 162,
                Name = "Tahm Kench",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/TahmKench_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/TahmKench.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/TahmKench/",
                Difficulty = 1,
                Role = 3,
                SubRole = 1,
                Aesthetic = 3
            },
            new Character
            {
                GameId = 2,
                CharacterId = 163,
                Name = "Thresh",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Thresh_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Thresh.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Thresh",
                Difficulty = 3,
                Role = 3,
                SubRole = 1,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Thresh.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 164,
                Name = "Vel'Koz",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Velkoz_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Velkoz.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Velkoz/",
                Difficulty = 3,
                Role = 3,
                SubRole = 1,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Velkoz.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 165,
                Name = "Zilean",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zilean_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zilean.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Zilean/",
                Difficulty = 2,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Zilean.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 166,
                Name = "Zyra",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Zyra_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Zyra.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Zyra/",
                Difficulty = 1,
                Role = 3,
                SubRole = 1,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Zyra.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 167,
                Name = "Ivern",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Ivern_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Ivern.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Ivern/",
                Difficulty = 3,
                Role = 3,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Ivern.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 168,
                Name = "Janna",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Janna_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Janna.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Janna/",
                Difficulty = 1,
                Role = 3,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Janna.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 169,
                Name = "Lulu",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Lulu_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Lulu.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Lulu/",
                Difficulty = 2,
                Role = 3,
                SubRole = 2,
                Aesthetic = 2,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Lulu.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 170,
                Name = "Nami",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Nami_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Nami.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Nami/",
                Difficulty = 1,
                Role = 3,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Nami.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 171,
                Name = "Rakan",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Rakan_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Rakan.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Rakan/",
                Difficulty = 3,
                Role = 3,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Rakan.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 172,
                Name = "Sona",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Sona_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Sona.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Sona/",
                Difficulty = 1,
                Role = 3,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Sona.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 173,
                Name = "Soraka",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Soraka_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Soraka.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Soraka/",
                Difficulty = 2,
                Role = 3,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Soraka.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 174,
                Name = "Taric",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Taric_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Taric.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Taric/",
                Difficulty = 2,
                Role = 3,
                SubRole = 2,
                Aesthetic = 1,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Taric.json"
            },
            new Character
            {
                GameId = 2,
                CharacterId = 175,
                Name = "Yuumi",
                Image = "https://ddragon.leagueoflegends.com/cdn/img/champion/splash/Yuumi_0.jpg",
                SmallImage = "https://ddragon.leagueoflegends.com/cdn/9.15.1/img/champion/Yuumi.png",
                CharacterUrl = "https://na.leagueoflegends.com/en/game-info/champions/Yuumi/",
                Difficulty = 3,
                Role = 3,
                SubRole = 2,
                Aesthetic = 3,
                ApiLocation = "http://ddragon.leagueoflegends.com/cdn/9.15.1/data/en_US/champion/Yuumi.json"
            }
            );


            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Overwatch",
                    Description = "Overwatch is a colorful team-based shooter game starring a diverse cast of powerful heroes. Travel the world, build a team, and contest objectives in exhilarating 6v6 combat.",
                    Download = "https://us.shop.battle.net/en-us/product/overwatch?blzcmp=ow_buy_nav",
                    Image = "https://stmed.net/sites/default/files/overwatch-hd-wallpapers-33472-8666477.jpg",
                    Video = "https://www.youtube.com/watch?v=dushZybUYnM&t=9s"

                },
                new Game
                {
                    GameId = 2,
                    Name = "League of Legends",
                    Description = "League of Legends is a fast-paced, competitive online game that blends the speed and intensity of real time strategy with role playing game elements. Two teams of powerful champions, each with a unique design and playstyle, battle head-to-head across multiple battlefields and game modes. With an ever-expanding roster of champions, frequent updates and a thriving tournament scene, League of Legends offers endless replayability for players of every skill level.",
                    Download = "https://signup.na.leagueoflegends.com/en/signup/index#/",
                    Image = "http://mumumaki.com/wp-content/uploads/2018/07/League-Of-Legends-Wallpaper.jpg",
                    Video = "https://www.youtube.com/watch?v=-157HBpPZ24"
                }

                );





        }

    }

}
