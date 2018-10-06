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
            ViewData["ErrorMessage"] = ErrorMessage;
            return View();
        }
        //[HttpPost]
        //public IActionResult Login(string Email, string Password)
        //{
        //    try
        //    {
        //        accountLogic.AccountLogin(new AccountLogin() { Email = Email, Password = Password });
        //        return RedirectToAction("Index", "Home");
        //    }
        //    catch (Exception ex)
        //    {
        //        ErrorMessage = ex.Message;
        //        return RedirectToAction("AccountLogin", "Account");
        //    }
        //}
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
            return View();
        }
    }
}