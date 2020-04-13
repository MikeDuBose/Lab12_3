﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using IceCreamShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace IceCreamShop.Controllers
{
    public class AdminController : Controller
    {
        IConfiguration ConfigRoot;
        DAL dal;

        public AdminController(IConfiguration config)
        {
            ConfigRoot = config;
            dal = new DAL(ConfigRoot.GetConnectionString("CoffeeShopDB"));
        }

        public IActionResult Index()
        {
            ViewData["Products"] = dal.GetProductsAll();

            return View();
        }

        [HttpPost]
        public IActionResult Add(Product prod)
        {
            //check the model for validity

            int result = dal.CreateProduct(prod);

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully added";
            }
            else
            {
                TempData["UserMsg"] = "Item not added";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        public IActionResult AddForm()
        {
            //creating a new blank product
            Product prod = new Product();

            //putting the blank Product instance into the view as the model
            return View(prod);
        }

        public IActionResult Delete(int id)
        {
            //eventually we'll either add a conf page or confirm deletion with JS in the Index

            int result = dal.DeleteProductById(id);
            //check the result--0 means no matching id, 1 means 1 row affected

            //add data for the view before handing off
            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully deleted";
            }
            else
            {
                TempData["UserMsg"] = "Item for deletion not found";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }

        //Different way of doing than AddForm/Add
        //two methods, same name, different annotations--one triggered by GET, the other POST
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Product prod = dal.GetProductById(id);

            if (prod == null)
            {
                return View("NoSuchItem");
            }
            else
            {
                return View(prod);
            }
        }

        [HttpPost]
        public IActionResult Edit(Product prod)
        {
            //check the model for validity

            int result = dal.UpdateProductById(prod);

            if (result == 1)
            {
                TempData["UserMsg"] = "Item successfully updated";
            }
            else
            {
                TempData["UserMsg"] = "Item not updated";
            }

            //don't always have to return a view
            //this will hand things off to the Index action
            return RedirectToAction("Index");
        }
    }
}