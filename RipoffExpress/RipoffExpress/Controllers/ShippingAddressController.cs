using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Logic;
using RipoffExpress.Models;

namespace RipoffExpress.Controllers
{
    public class ShippingAddressController : Controller
    {
        ShippingAddressLogic logic = new ShippingAddressLogic();

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
        public PartialViewResult ShippingAddressEdit(int? Id)
        {
            return PartialView("../ShippingAddress/_ShippingAddressEdit", logic.AddressDetails(Id));
        }
        [HttpPost]
        public PartialViewResult ShippingAddressEdit(int? Id, string Address, string PostalCode, string City, string Province, string Country, string PhoneNumber, bool Default)
        {
            logic.SaveChanges(new ShippingAddress(Id, Address, PostalCode, City, Province, Country, PhoneNumber, Default));
            return PartialView("../ShippingAddress/_ShippingAddressEdit", logic.AddressDetails(Id));
        }
        [HttpPost]
        public IActionResult DeleteAddress(int? Id)
        {
            logic.DeleteAddress(Id);
            return RedirectToAction("../Account/AccountDetails");
        }
        [HttpPost]
        public IActionResult SetAsDefault(int? Id)
        {
            logic.RemoveDefault(HttpContext.Session.GetInt32("UserId"));
            logic.SetAsDefault(Id);
            return RedirectToAction("../Account/AccountDetails");
        }
    }
}