using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IceCreamShop.Models;

namespace IceCreamShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime today = DateTime.Now;
            string date = today.ToString("MMddyyyy");
            string time = today.ToString("hh:mm:ss");
            ViewData["time"] = time;
            ViewData["date"] = date;
            return View();//with no arg here, it returns the view named (this controller action).cshtml
        }

        public IActionResult Menu()
        {
            string[] flavors = { "Brewed", "Cold Brew", "Au Lait", "Double Espresso", "Americano", "Cortado", "Cappucino", "Latte", "Mocha", "Frappe", "Beans by the pound", 
            "Iced Tea", "Hot Tea", "Chai Tea", "Chai Latte", "Matcha Latte", "Hot Chocolate"};
            string[] prices = { "1.99", "2.99", "3.50", "5.00", "3.50", "3.50", "4.00", "6.00", "5.00", "4.50", "20.00", "3.50", "3.50", "4.50", "4.50", "5.00", "2.00"};
            ViewData["flavors"] = flavors;
            ViewData["prices"] = prices;
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
