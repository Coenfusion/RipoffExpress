using System;
using Microsoft.AspNetCore.Mvc;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.Logic.Account;

namespace RipoffExpress.Controllers
{
    public class AccountController : Controller
    {
        AccountLogic accountLogic = new AccountLogic();
        [TempData]
        public string ErrorMessage { get; set; }

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
                AccountLogin a;
                accountLogic.Login(a = new AccountLogin() { Email = Email, Password = Password });
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
                accountLogic.RegisterNewAccount(new AccountRegister() { Email = Email, Username = Username, Password = Password, RepeatPassword = RepeatPassword });
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
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        [HttpGet]
        public PartialViewResult AccountOverview(int Id)
        {
            //get id from session u fag
            Id = 2;
           return PartialView("../AccountPartials/AccountOverview", accountLogic.GetAccountDetails(Id));
        }
    }
}