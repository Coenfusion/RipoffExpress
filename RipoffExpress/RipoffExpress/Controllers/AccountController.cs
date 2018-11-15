using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.Logic.Account;
using System.Web;

namespace RipoffExpress.Controllers
{
    public class AccountController : Controller 
    {
        AccountLogic accountLogic = new AccountLogic();
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
           return PartialView("../AccountPartials/AccountOverview", accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId")));
        }
        [HttpPost]
        public PartialViewResult AccountChanges()
        {
            //GetAccountbyId
            AccountDetails a = accountLogic.GetAccountDetails(HttpContext.Session.GetInt32("UserId"));
            return PartialView("../AccountPartials/AccountChanges", accountLogic.SaveChanges(a));
        }
    }
}