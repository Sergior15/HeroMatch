﻿// <auto-generated />
using HeroMatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeroMatch.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190731192926_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeroMatch.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilterId");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("CharacterId");

                    b.ToTable("Character");

                    b.HasData(
                        new { CharacterId = 1, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reinhardt/hero-select-portrait.png", Name = "Reinhardt" },
                        new { CharacterId = 2, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/orisa/hero-select-portrait.png", Name = "Orisa" },
                        new { CharacterId = 3, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/dva/hero-select-portrait.png", Name = "D. Va" },
                        new { CharacterId = 4, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/winston/hero-select-portrait.png", Name = "Winston" },
                        new { CharacterId = 5, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/roadhog/hero-select-portrait.png", Name = "Roadhog" },
                        new { CharacterId = 6, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/wrecking-ball/hero-select-portrait.png", Name = "Wrecking Ball" },
                        new { CharacterId = 7, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sigma/hero-select-portrait.png", Name = "Sigma" },
                        new { CharacterId = 8, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zarya/hero-select-portrait.png", Name = "Zarya" },
                        new { CharacterId = 9, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ashe/hero-select-portrait.png", Name = "Ashe" },
                        new { CharacterId = 10, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mccree/hero-select-portrait.png", Name = "McCree" },
                        new { CharacterId = 11, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/hanzo/hero-select-portrait.png", Name = "Hanzo" },
                        new { CharacterId = 12, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/widowmaker/hero-select-portrait.png", Name = "Widowmaker" },
                        new { CharacterId = 13, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/soldier-76/hero-select-portrait.png", Name = "Soldier: 76" },
                        new { CharacterId = 14, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/reaper/hero-select-portrait.png", Name = "Reaper" },
                        new { CharacterId = 15, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/sombra/hero-select-portrait.png", Name = "Sombra" },
                        new { CharacterId = 16, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/genji/hero-select-portrait.png", Name = "Genji" },
                        new { CharacterId = 17, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/doomfist/hero-select-portrait.png", Name = "Doomfist" },
                        new { CharacterId = 18, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/tracer/hero-select-portrait.png", Name = "Tracer" },
                        new { CharacterId = 19, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/torbjorn/hero-select-portrait.png", Name = "Torbjörn" },
                        new { CharacterId = 20, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/symmetra/hero-select-portrait.png", Name = "Symmetra" },
                        new { CharacterId = 21, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/pharah/hero-select-portrait.png", Name = "Pharah" },
                        new { CharacterId = 22, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mei/hero-select-portrait.png", Name = "Mei" },
                        new { CharacterId = 23, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/junkrat/hero-select-portrait.png", Name = "Junkrat" },
                        new { CharacterId = 24, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/bastion/hero-select-portrait.png", Name = "Bastion" },
                        new { CharacterId = 25, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/baptiste/hero-select-portrait.png", Name = "Baptiste" },
                        new { CharacterId = 26, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/brigitte/hero-select-portrait.png", Name = "Brigitte" },
                        new { CharacterId = 27, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/ana/hero-select-portrait.png", Name = "Ana" },
                        new { CharacterId = 28, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/lucio/hero-select-portrait.png", Name = "Lúcio" },
                        new { CharacterId = 29, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/mercy/hero-select-portrait.png", Name = "Mercy" },
                        new { CharacterId = 30, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/moira/hero-select-portrait.png", Name = "Moira" },
                        new { CharacterId = 31, FilterId = 0, Image = "https://d1u1mce87gyfbn.cloudfront.net/hero/zenyatta/hero-select-portrait.png", Name = "Zenyatta" }
                    );
                });

            modelBuilder.Entity("HeroMatch.Models.Filter", b =>
                {
                    b.Property<int>("FilterId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterId");

                    b.Property<int>("Difficulty");

                    b.Property<int>("Role");

                    b.Property<int>("SubRole");

                    b.HasKey("FilterId");

                    b.ToTable("Filter");

                    b.HasData(
                        new { FilterId = 1, CharacterId = 1, Difficulty = 1, Role = 1, SubRole = 1 },
                        new { FilterId = 2, CharacterId = 2, Difficulty = 2, Role = 1, SubRole = 1 },
                        new { FilterId = 3, CharacterId = 3, Difficulty = 3, Role = 1, SubRole = 1 },
                        new { FilterId = 4, CharacterId = 4, Difficulty = 2, Role = 1, SubRole = 1 },
                        new { FilterId = 5, CharacterId = 5, Difficulty = 1, Role = 1, SubRole = 2 },
                        new { FilterId = 6, CharacterId = 6, Difficulty = 2, Role = 1, SubRole = 2 },
                        new { FilterId = 7, CharacterId = 7, Difficulty = 3, Role = 1, SubRole = 2 },
                        new { FilterId = 8, CharacterId = 8, Difficulty = 3, Role = 1, SubRole = 2 },
                        new { FilterId = 9, CharacterId = 9, Difficulty = 2, Role = 2, SubRole = 1 },
                        new { FilterId = 10, CharacterId = 10, Difficulty = 2, Role = 2, SubRole = 1 },
                        new { FilterId = 11, CharacterId = 11, Difficulty = 3, Role = 2, SubRole = 1 },
                        new { FilterId = 12, CharacterId = 12, Difficulty = 3, Role = 2, SubRole = 1 },
                        new { FilterId = 13, CharacterId = 13, Difficulty = 1, Role = 2, SubRole = 1 },
                        new { FilterId = 14, CharacterId = 14, Difficulty = 1, Role = 2, SubRole = 2 },
                        new { FilterId = 15, CharacterId = 15, Difficulty = 3, Role = 2, SubRole = 2 },
                        new { FilterId = 16, CharacterId = 16, Difficulty = 3, Role = 2, SubRole = 2 },
                        new { FilterId = 17, CharacterId = 17, Difficulty = 2, Role = 2, SubRole = 2 },
                        new { FilterId = 18, CharacterId = 18, Difficulty = 2, Role = 2, SubRole = 2 },
                        new { FilterId = 19, CharacterId = 19, Difficulty = 2, Role = 2, SubRole = 3 },
                        new { FilterId = 20, CharacterId = 20, Difficulty = 3, Role = 2, SubRole = 3 },
                        new { FilterId = 21, CharacterId = 21, Difficulty = 2, Role = 2, SubRole = 3 },
                        new { FilterId = 22, CharacterId = 22, Difficulty = 2, Role = 2, SubRole = 3 },
                        new { FilterId = 23, CharacterId = 23, Difficulty = 1, Role = 2, SubRole = 3 },
                        new { FilterId = 24, CharacterId = 24, Difficulty = 1, Role = 2, SubRole = 3 },
                        new { FilterId = 25, CharacterId = 25, Difficulty = 2, Role = 3, SubRole = 1 },
                        new { FilterId = 26, CharacterId = 26, Difficulty = 1, Role = 3, SubRole = 1 },
                        new { FilterId = 27, CharacterId = 27, Difficulty = 3, Role = 3, SubRole = 1 },
                        new { FilterId = 28, CharacterId = 28, Difficulty = 2, Role = 3, SubRole = 2 },
                        new { FilterId = 29, CharacterId = 29, Difficulty = 1, Role = 3, SubRole = 2 },
                        new { FilterId = 30, CharacterId = 30, Difficulty = 2, Role = 3, SubRole = 2 },
                        new { FilterId = 31, CharacterId = 31, Difficulty = 3, Role = 3, SubRole = 2 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
