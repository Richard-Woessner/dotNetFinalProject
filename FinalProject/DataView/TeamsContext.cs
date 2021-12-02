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
                    name = "Sen",
                    imgURL = "",
                    country = "USA",
                    description = "sl;kdjf"

                }
                );


            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    name = "Shahzeb 'ShahZaM' Khan",
                    imgURL = "https://liquipedia.net/commons/images/b/b4/Sentinels_ShahZaM_may_2021.png",
                    team = "USA",
                    description = "IGL"
                }
                );

        }
    }
}
