using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.Logic;
using System.Web;

namespace RipoffExpress.Controllers
{
    public class AccountController : Controller 
    {
        AccountLogic accountLogic = new AccountLogic();
        ShippingAddressLogic shippingAddressLogic = new ShippingAddressLogic();
        [TempData]
        public string ErrorMessage { get; set; }
        public string SessionMessage { get; set; }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccountLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AccountLogin(string Email, string Password)
        {
            try
            {
                Account a;
                accountLogic.Login(a = new Account(Email, Password));

                HttpContext.Session.SetString("Email", a.Email);
                HttpContext.Session.SetInt32("UserId", accountLogic.GetUserId(a));

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("AccountLogin", "Account");
            }
        }
        public IActionResult AccountRegister()
        {
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
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
        public IActionResult AccountDetails()
        {
            ViewData["SessionMessage"] = HttpContext.Session.GetString("Email");
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        [HttpGet]
        public PartialViewResult AccountOverview()
        {
           return PartialView("../Account/__AccountOverview", accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")));
        }
        [HttpGet]
        public PartialViewResult AccountChanges()
        {
            AccountDetails a = accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId"));
            return PartialView("../Account/_AccountChanges");
        }
        [HttpPost]
        public IActionResult AccountChanges(string Email, string Username, string CurrentPassword, string NewPassword)
        {
            try
            {
                AccountDetails CurrentDetails = accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId"));
                AccountChanges NewDetails = new AccountChanges()
                {
                    Email = Email,
                    Username = Username,
                    CurrentPassword = CurrentPassword,
                    NewPassword = NewPassword
                };

                accountLogic.SaveChanges(CurrentDetails, NewDetails);
                ErrorMessage = "Changes have been made.";
                return RedirectToAction("AccountDetails","Account");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return RedirectToAction("AccountDetails", "Account");
            }
        }
        [HttpGet]
        public PartialViewResult AccountAddressBook()
        {
            return PartialView("../Account/_AccountAddressBook", shippingAddressLogic.GetAddresses(HttpContext.Session.GetInt32("UserId")));
        }
    }
}