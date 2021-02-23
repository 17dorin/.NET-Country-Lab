using CountriesDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesDotNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<Country> countries = new List<Country>
        { 
            new Country { name = "usa", language = "english", greeting = "Hello World", description = "Land of the burgers", colors = new List<string> {"red", "white", "blue" } },
            new Country { name = "mexico", language = "spanish", greeting = "Hola Mundo", description = "Yep, it's Mexico", colors = new List<string> {"red", "white", "green" } },
            new Country { name = "germany", language = "german", greeting = "Hallo Welt", description = "Yep, Germany", colors = new List<string> {"red", "black", "gold" } }
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(countries);
        }
        [HttpPost]
        public IActionResult Index(string counts)
        {
            foreach(Country c in countries)
            {
                if(c.name == counts)
                {
                    TempData["name"] = c.name;
                    TempData["language"] = c.language;
                    TempData["greeting"] = c.greeting;
                    TempData["description"] = c.description;
                    TempData["colors"] = c.colors;
                }
            }
            return View(countries);
        }

        public IActionResult Description()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Privacy()
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
