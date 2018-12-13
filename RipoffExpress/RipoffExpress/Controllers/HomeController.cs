using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic.ProductLogic;
using RipoffExpress.Models;

namespace RipoffExpress.Controllers
{
    public class HomeController : Controller
    {
        ProductLogic ProductLogic = new ProductLogic();

        [TempData]
        public string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult MostRecentProducts()
        {
            return PartialView("../Product/_ProductOverview", ProductLogic.MostRecentProducts());
        }
        [HttpGet]
        public PartialViewResult LoadCategories()
        {
            return PartialView("../Product/_ProductCategory", ProductLogic.LoadCategories());
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
