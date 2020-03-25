using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IceCreamShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("OrderIndex");
        }

        public IActionResult Order(string fname, string lname, string email, string password)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["password"] = password;
            return View();
        }
    }
}