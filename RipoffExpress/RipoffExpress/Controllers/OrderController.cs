using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;

namespace RipoffExpress.Controllers
{
    public class OrderController : Controller
    {
        OrderLogic OrderLogic = new OrderLogic();

        public IActionResult RemoveProductFromOrder(int? productId, int? orderId)
        {
            OrderLogic.RemoveProductFromOrder(productId, orderId);
            return RedirectToAction("ShoppingCart", "Home");
        }
        public IActionResult OrderFinalization(int? orderId)
        {
            OrderLogic.OrderFinalization(orderId);
            return View(OrderLogic.OrderById(orderId));
        }
    }
}