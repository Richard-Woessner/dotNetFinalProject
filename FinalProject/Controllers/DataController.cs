using FinalProject.DataView;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class DataController : Controller
    {

        private readonly TeamsContext teamsContext;

        public DataController(TeamsContext context)
        {
            teamsContext = context;


        }

        public String Index()
        {
            return "Test";
        }

        [HttpPost]
        public RedirectToActionResult newTeam(String name, String country, String description, String imgURL) {

            Team newTeam = new Team
            {
                name = name,
                country = country,
                description = description,
                imgURL = imgURL
            };

            teamsContext.Add(newTeam);
            teamsContext.SaveChanges();
            return RedirectToAction("Teams", "Home", new { area = "" });
        }

        [HttpPost]
        public RedirectToActionResult newPlayer(String name, String team, String description, String imgURL)
        {

            Player newPlayer = new Player
            {
                name = name,
                team = team,
                description = description,
                imgURL = imgURL
            };

            teamsContext.Add(newPlayer);
            teamsContext.SaveChanges();
            return RedirectToAction("Players", "Home", new { area = "" });
        }
    }
}
