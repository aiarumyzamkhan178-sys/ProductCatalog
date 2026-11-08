
using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ноутбук", Price = 350000, Category = "Техника", IsAvailable = true },
                new Product { Id = 2, Name = "Телефон", Price = 250000, Category = "Техника", IsAvailable = true },
                new Product { Id = 3, Name = "Құлаққап", Price = 15000, Category = "Аксессуар", IsAvailable = false },
                new Product { Id = 4, Name = "Пернетақта", Price = 12000, Category = "Аксессуар", IsAvailable = true }
            };

            ViewBag.Title = "Тауарлар каталогы";
            ViewBag.Description = "Біздің интернет дүкеніміздің тауарлары";

            return View(products);
        }
    }
}
