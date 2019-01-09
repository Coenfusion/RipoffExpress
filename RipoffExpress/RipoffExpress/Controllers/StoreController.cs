using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RipoffExpress.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Store()
        {
            return View();
        }
    }
}