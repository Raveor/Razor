using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product myProduct = new Product
            {
                ProductID = 1,
                Name = "Kajak",
                Description = "Jednoosobowa łódka",
                Category = "Sporty wodne",
                Price = 275M
            };

            ViewBag.StockLevel = 2;

            return View(myProduct);
        }
    }
}