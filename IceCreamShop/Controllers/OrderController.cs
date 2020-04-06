using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IceCreamShop.Models;
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

        public IActionResult Order(string FirstName, string LastName, string email, string phoneNum, string age, string options, string password)
        {
            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["email"] = email;
            ViewData["phoneNum"] = phoneNum;
            ViewData["age"] = age;
            ViewData["options"] = options;
            ViewData["password"] = password;
            return View();
        }

        public IActionResult UserModel(UserModel user)
        {
            if (ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                ViewData["errorMsg"] = "Your form had errors. Please correct and re-submit.";
                return View("Dish", user);
            }
        }
    }
}