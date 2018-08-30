using BartenderApp.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Controller
{
    public class HomeController
    {

        public static List<Drink> Orders = new List<Drink>();

        private static List<Drink> drinks
            = new List<Drink>()
            {
                new Drink {Name = "Drink 1", Description = "Do not drink", Price = 1},
                new Drink {Name = "Drink 2", Description = "Rum mostly coke", Price = 6},
                new Drink {Name = "Drink 3", Description = "Mint and vodka", Price = 9},
                new Drink {Name = "Drink 3", Description = "Ginger Beer and vodka", Price = 8}
            };

        public ViewResult Index()
        {

            return View(Index);  
        }

        public RedirectToRouteResult Order(Drink drink) 
        {
            Orders.Add(drink);
            return RedirectToAction("Index"); 
        }
    }
}
