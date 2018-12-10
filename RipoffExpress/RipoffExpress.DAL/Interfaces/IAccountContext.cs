using System;
using RipoffExpress.Models.AccountModels;

namespace RipoffExpress.DAL.Interfaces
{
    public interface IAccountContext
    {
        bool Login(Account a);
        void Register(Account a);
        bool CheckAvailability(Account a);
        AccountDetails GetAccountDetails(int? Id);
        int GetUserId(Account a);
        void SaveChanges(AccountChanges a, int? Id);
    }
}
