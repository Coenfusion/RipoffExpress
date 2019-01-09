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
    public class ShoppingCartController : Controller
    {
        OrderLogic OrderLogic = new OrderLogic();
        AccountLogic AccountLogic = new AccountLogic();

        [TempData]
        public string ErrorMessage { get; set; }

        public IActionResult ShoppingCart()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                return View();
            }
            ErrorMessage = "Log in before visiting your shopping cart.";
            return RedirectToAction("AccountLogin", "Account");
        }
        public PartialViewResult ShoppingCartProducts()
        {
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                Account = AccountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")),
                Order = OrderLogic.OrderByStatus(HttpContext.Session.GetInt32("UserId"), OrderStatus.ShoppingCart)
            };
            return PartialView("../ShoppingCart/_ShoppingCartProducts", shoppingCartViewModel);
        }
        public PartialViewResult ShoppingCartAddressBook()
        {
            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                Account = AccountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")),
                Order = OrderLogic.OrderByStatus(HttpContext.Session.GetInt32("UserId"), OrderStatus.ShoppingCart)
            };
            return PartialView("../ShoppingCart/_ShoppingCartAddressBook", shoppingCartViewModel);
        }
    }
}