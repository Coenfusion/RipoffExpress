using System;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.Repository.Account;

namespace RipoffExpress.Logic.Account
{
    public class AccountLogic
    {
        AccountRepository repo = new AccountRepository();
        public bool RegisterNewAccount(AccountRegister a)
        {
            //Exceptions zijn K-01.1
            //B-01.3
            if (string.IsNullOrEmpty(a.Username) || string.IsNullOrEmpty(a.Password) || string.IsNullOrEmpty(a.RepeatPassword) || string.IsNullOrEmpty(a.Email))
            {
                throw new Exception("Not all fields have been filled in.");
            }
            //B-01.2
            if (string.Compare(a.Password, a.RepeatPassword) > 0)
            {
                throw new Exception("Passwords do not match");
            }
            //B-01.1
            if (repo.CheckAvailability(a))
            {
                throw new Exception("This account already exists.");
            }
            return repo.Register(a);
        }
    }
}
