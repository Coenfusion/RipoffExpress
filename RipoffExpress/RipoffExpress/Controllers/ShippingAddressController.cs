using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;
using RipoffExpress.Models;

namespace RipoffExpress.Controllers
{
    public class ShippingAddressController : Controller
    {
        ShippingAddressLogic logic = new ShippingAddressLogic();

        public IActionResult Index()
        {
            return View();
        }
        //Create, Edit, Delete
        public PartialViewResult ShippingAddressCreation()
        {
            return PartialView("../ShippingAddress/ShippingAddressCreation");
        }
        [HttpPost]
        public PartialViewResult ShippingAddressCreation(string Address, string PostalCode, string City, string Province, string Country, string PhoneNumber)
        {
            logic.CreateNewAddress(new ShippingAddress(Address, PostalCode, City, Province, Country, PhoneNumber), HttpContext.Session.GetInt32("UserId"));
            return PartialView("../ShippingAddress/ShippingAddressCreation");
        }
        [HttpGet]
        public PartialViewResult ShippingAddressEdit(int? AddressId)
        {
            return PartialView("../ShippingAddress/ShippingAddressEdit", logic.AddressDetails(AddressId));
        }
        [HttpPost]
        public PartialViewResult ShippingAddressEdit(int? AddressId, string Address, string PostalCode, string City, string Province, string Country, string PhoneNumber)
        {
            logic.SaveChanges(new ShippingAddress(Address, PostalCode, City, Province, Country, PhoneNumber), HttpContext.Session.GetInt32("UserId"), AddressId);
            return PartialView("../ShippingAddress/ShippingAddressEdit", logic.AddressDetails(AddressId));
        }
        public void DeleteAddress(int? AddressId) => logic.DeleteAddress(AddressId);
        public void SetAsDefault(int? AddressId) => logic.SetAsDefault(AddressId);
    }
}