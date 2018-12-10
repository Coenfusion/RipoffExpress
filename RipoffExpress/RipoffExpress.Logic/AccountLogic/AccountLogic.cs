using System;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.Repository;
using RipoffExpress.DAL;

namespace RipoffExpress.Logic
{
    public class AccountLogic
    {
        AccountRepository repo = new AccountRepository(ContextType.MSSQLContext);
      
        public void RegisterNewAccount(Account a)
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
            if (!repo.CheckAvailability(a))
            {
                throw new Exception("This account already exists.");
            }
            repo.Register(a);
            return;
        }
        public bool Login(Account a)
        {
            //Exceptions zijn K-02.1
            // B-02.2
            if (string.IsNullOrEmpty(a.Email))
            {
                throw new Exception("Please enter a email adress.");
            }
            // B-02.2
            if (string.IsNullOrEmpty(a.Password))
            {
                throw new Exception("Please enter a password.");
            }
            return repo.Login(a);
        }
        public AccountDetails GetAccountDetails(int? Id)
        {
            return repo.GetAccountDetails(Id);
        }
        public void SaveChanges(AccountDetails CurrentDetails, AccountChanges NewDetails)
        {
            if (NewDetails.CurrentPassword != NewDetails.CurrentPassword)
            {
                throw new Exception("Password is incorrect.");
            }
            if (!repo.CheckAvailability(new Account() { Email = NewDetails.Email, Username = ""}))
            {
                throw new Exception("Email is already in use.");
            }
            if (!repo.CheckAvailability(new Account() { Username = NewDetails.Username, Email = "" }))
            {
                throw new Exception("Username is already in use.");
            }
            repo.SaveChanges(NewDetails, CurrentDetails.Id);
            return;
        }
        public int GetUserId(Account a)
        {
            return repo.GetUserId(a);
        }
    }
}
