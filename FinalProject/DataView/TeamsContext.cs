using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.DataView
{
    public class TeamsContext : DbContext
    {
        public TeamsContext(DbContextOptions<TeamsContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                    new Team
                    {
                        Id = 1,
                        name = "Sentinels",
                        imgURL = "https://upload.wikimedia.org/wikipedia/en/thumb/2/24/Sentinels_Logo.svg/1200px-Sentinels_Logo.svg.png",
                        country = "USA",
                        description = "Sentinels is an American esports organization based in Los Angeles"

                    },

                    new Team
                    {
                        Id = 2,
                        name = "Liquid",
                        imgURL = "https://www.gamereactor.eu/media/03/teamliquiddetails_3230353b.jpg",
                        country = "Europe",
                        description = "Team Liquid is a professional esports organization founded in the Netherlands in 2000"

                    },

                    new Team
                    {
                        Id = 3,
                        name = "Sen",
                        imgURL = "https://owcdn.net/img/5f3c894bdf4ba.png",
                        country = "Korea",
                        description = "Vision Strikers is a Korean VALORANT team formed by a roster of former CS:GO players known as MVP PK."

                    }
                );


            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    name = "Shahzeb 'ShahZaM' Khan",
                    imgURL = "https://liquipedia.net/commons/images/b/b4/Sentinels_ShahZaM_may_2021.png",
                    team = "USA",
                    description = "Shahzeb 'ShahZaM' Khan (born October 8, 1993) is an American player who currently plays for Sentinels. He is a former Counter-Strike: Global Offensive player who is mostly known for his time in Cloud9, OpTic and Complexity Gaming. "
                },
                new Player
                {
                    Id = 2,
                    name = "Ayaz 'nAts' Akhmetshin",
                    imgURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fowcdn.net%2Fimg%2F60a0cf3460718.png&f=1&nofb=1",
                    team = "Gambit",
                    description = "Ayaz Akhmetshin (born July 1, 2002) is a Russian player who is currently playing for Gambit Esports. He is a former Counter-Strike: Global Offensive player. "
                },
                new Player
                {
                    Id = 3,
                    name = "Kim 'stax' Gu-taek",
                    imgURL = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fggscore.com%2Fmedia%2Flogo%2Fp21729.png&f=1&nofb=1",
                    team = "Vision Strikers",
                    description = "Kim 'stax' Gu-taek (born February 16, 2000) is a South Korean player who currently plays for Vision Strikers. He is a former professional Counter - Strike: Global Offensive player who was most known for his time in MVP PK."
                }
                );

        }
    }
}
