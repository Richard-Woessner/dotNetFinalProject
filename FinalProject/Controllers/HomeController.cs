using FinalProject.DataView;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TeamsContext teamsContext;

        public HomeController(ILogger<HomeController> logger, TeamsContext context)
        {
            _logger = logger;
            teamsContext = context;


        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Valorant()
        {
            return View();
        }
        public IActionResult Teams()
        {
            return View(teamsContext.Teams.ToList());
        }
        public IActionResult Players()
        {
            return View(teamsContext.Player.ToList());
        }
        public IActionResult Riot()
        {
            return View();
        }
        public IActionResult AboutMe()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
