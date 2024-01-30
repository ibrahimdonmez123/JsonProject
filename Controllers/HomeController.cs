using System;
using JsonProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace JsonExampleProject.Controllers
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
            List<Product> products = GetSampleProducts();

            string jsonProducts = JsonConvert.SerializeObject(products);

            ViewBag.JsonData = jsonProducts;

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


        private List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, İsim = "Laptop", Fiyat = 1200.00m, Tarih = DateTime.Now },
                new Product { Id = 2, İsim = "Smartphone", Fiyat = 800.00m, Tarih = DateTime.Now },
                new Product { Id = 3, İsim = "Headphones", Fiyat = 100.00m, Tarih = DateTime.Now }
            };
        }
    }
}
