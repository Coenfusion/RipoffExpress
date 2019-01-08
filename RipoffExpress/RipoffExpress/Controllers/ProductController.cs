using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;

namespace RipoffExpress.Controllers
{
    public class ProductController : Controller
    {
        ProductLogic ProductLogic = new ProductLogic();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult ProductOverview(int? Id)
        {
            return PartialView("../Product/_ProductOverview", ProductLogic.ProductByCategory(Id));
        }
        public IActionResult Product(int? Id)
        {
            int pid = Id ?? 1;
            return View(ProductLogic.ProductById(pid));
        }
        [HttpGet]
        public PartialViewResult ProductByCriteria(string criteria)
        {
            return PartialView("../Product/_ProductOverview", ProductLogic.ProductByCiteria(criteria));
        }
    }
}