
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;
using System.Collections.Generic;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Ноутбук ASUS",
                    Price = 350000,
                    Category = "Электроника",
                    IsAvailable = true
                },

                new Product
                {
                    Id = 2,
                    Name = "iPhone 15",
                    Price = 420000,
                    Category = "Смартфон",
                    IsAvailable = true
                },

                new Product
                {
                    Id = 3,
                    Name = "Құлаққап",
                    Price = 15000,
                    Category = "Аксессуар",
                    IsAvailable = false
                },

                new Product
                {
                    Id = 4,
                    Name = "Samsung TV",
                    Price = 280000,
                    Category = "Теледидар",
                    IsAvailable = true
                }
            };

            ViewBag.StoreName = "ProductCatalog";
            ViewBag.Description = "Біздің интернет-дүкеніміздің тауарлары"; 
            return View(products);
        }
    }
}
