using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;
using RipoffExpress.Models;

namespace RipoffExpress.Controllers
{
    public class StoreController : Controller
    {
        StoreLogic StoreLogic = new StoreLogic();

        [HttpGet]
        public IActionResult Store()
        {
            return View(StoreLogic.StoreDetails(HttpContext.Session.GetInt32("UserId")));
        }
        public PartialViewResult StoreCategories()
        {
            return PartialView("../Store/_StoreCategories", StoreLogic.StoreDetails(HttpContext.Session.GetInt32("UserId")));
        }
        public PartialViewResult StoreProducts()
        {
            return PartialView("../Store/_StoreProducts", StoreLogic.StoreDetails(HttpContext.Session.GetInt32("UserId")));
        }
        public IActionResult StoreProductManagement()
        {
            return View();
        }
    }
}