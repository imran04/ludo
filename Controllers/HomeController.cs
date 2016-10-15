using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using loduApp.Models;

namespace loduApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Place p1 = new Place
            {
                Color = Color.Red,
                Position = 22
            };
            Place p2 = new Place
            {
                Color = Color.Green,
                Position = 9
            };
            ViewData["p1"] = p1;
            ViewData["p2"] = p2;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
