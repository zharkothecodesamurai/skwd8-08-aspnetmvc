﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaApp.Web.Models.Domain;
using PizzaApp.Web.Models.Enums;
using PizzaApp.Web.Models.ViewModels;

namespace PizzaApp.Web.Controllers
{
    public class OrderController : Controller
    {
        public User User { get; set; }

        public List<Pizza> Pizzas { get; set; } = new List<Pizza>
        {
            new Pizza{ Id = 1, Name = "Pizza 1"},
            new Pizza{ Id = 2, Name = "Pizza 2"},
            new Pizza{ Id = 3, Name = "Pizza 3"},
            new Pizza{ Id = 4, Name = "Pizza 4"},
        };

        public static List<OrderViewModel> Orders { get; set; } = new List<OrderViewModel>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "Wlcome to Pizza-App orders";

            return View("Order", Orders);
        }

        [HttpGet]
        public IActionResult PlaceOrder()
        {
            ViewBag.Title = "Place an order";

            var pizzasNames = Pizzas.Select(x => x.Name).ToList();

            ViewData["Pizzas"] = pizzasNames;

            ViewData["PizzaSize"] = Enum.GetValues(typeof(PizzaSize)).Cast<PizzaSize>().ToList();

            return View();
        }
        [HttpPost]
        public IActionResult PlaceOrder(OrderViewModel order)
        {
            Orders.Add(order);
            return RedirectToAction("Index","Order",order);
        }
    }
}
