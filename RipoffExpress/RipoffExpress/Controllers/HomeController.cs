using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;
using RipoffExpress.Models;

namespace RipoffExpress.Controllers
{
    public class HomeController : Controller
    {
        ProductLogic ProductLogic = new ProductLogic();
        AccountLogic AccountLogic = new AccountLogic();
        OrderLogic OrderLogic = new OrderLogic();

        [TempData]
        public string ErrorMessage { get; set; }

        public IActionResult Index()
        {
            return View(ProductLogic.LoadCategories());
        }
        public IActionResult ShoppingCart()
        {
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                account = AccountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")),
                order = OrderLogic.OrderByStatus(HttpContext.Session.GetInt32("UserId"), OrderStatus.ShoppingCart)
            };
            return View(shoppingCartViewModel);
        }
        [HttpGet]
        public PartialViewResult MostRecentProducts()
        {
            return PartialView("../Product/_ProductOverview", ProductLogic.MostRecentProducts());
        }
        [HttpGet]
        public PartialViewResult ProductOverview(int? id)
        {
            var pid = id ?? 1;
            return PartialView("../Product/_ProductOverview", ProductLogic.ProductByCategory(pid));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
