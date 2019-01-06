using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RipoffExpress.Models;
using RipoffExpress.Logic;

namespace RipoffExpress.Controllers
{
    public class AccountController : Controller 
    {
        AccountLogic accountLogic = new AccountLogic();
        ShippingAddressLogic shippingAddressLogic = new ShippingAddressLogic();
        OrderLogic orderLogic = new OrderLogic();

        [TempData]
        public string ErrorMessage { get; set; }
        public string SessionMessage { get; set; }

        //Load Views
        public IActionResult AccountLogin()
        {
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        public IActionResult AccountRegister()
        {
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        public IActionResult AccountDetails()
        {
            ViewData["SessionMessage"] = HttpContext.Session.GetString("Email");
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        public IActionResult AccountLogout()
        {
            HttpContext.Session.Remove("UserId");
            return RedirectToAction("Index", "Home");
        }
        
        //Actions
        [HttpPost]
        public IActionResult AccountLogin(string Email, string Password)
        {
            try
            {
                Account account = new Account(Email, Password);
                if (accountLogic.Login(account))
                {
                    HttpContext.Session.SetString("Email", account.Email);
                    HttpContext.Session.SetInt32("UserId", accountLogic.GetUserId(account));
                    return RedirectToAction("Index", "Home");
                }
                ErrorMessage = "Email and/or password is incorrect.";
                return RedirectToAction("AccountLogin","Account");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("AccountLogin", "Account");
            }
        }
        [HttpPost]
        public IActionResult AccountRegister(string Email, string Username, string Password, string RepeatPassword)
        {
            try
            {
                accountLogic.RegisterNewAccount(new Account(Email, Username, Password, RepeatPassword));
                return RedirectToAction("AccountLogin", "Account");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("AccountRegister","Account");
            }
        }
        [HttpPost]
        public IActionResult AccountChanges(string Email, string Username, string Password, string NewPassword)
        {
            try
            {
                AccountDetails a = accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId"));
                accountLogic.SaveChanges(a, new AccountChanges(Email, Username, Password, NewPassword));
                ErrorMessage = "Changes have been made.";
                return RedirectToAction("AccountDetails", "Account");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("AccountDetails", "Account");
            }
        }
        //Load Partials
        [HttpGet]
        public PartialViewResult AccountOverview()
        {
           return PartialView("../Account/_AccountOverview", accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")));
        }
        [HttpGet]
        public PartialViewResult AccountChanges()
        {
            AccountDetails a = accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId"));
            return PartialView("../Account/_AccountChanges", a);
        }
        [HttpGet]
        public PartialViewResult AccountOrders()
        {
            return PartialView("../Account/_AccountOrders", orderLogic.OrderOverview(HttpContext.Session.GetInt32("UserId")));
        }
        [HttpGet]
        public PartialViewResult AccountAddressBook()
        {
            return PartialView("../Account/_AccountAddressBook", shippingAddressLogic.GetAddresses(HttpContext.Session.GetInt32("UserId")));
        }
    }
}