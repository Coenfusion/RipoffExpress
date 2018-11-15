using System;
using RipoffExpress.Models.AccountModels;

namespace RipoffExpress.DAL.Interfaces
{
    public interface IAccountContext
    {
        bool Login(Models.AccountModels.Account a);
        bool Register(Models.AccountModels.Account a);
        bool CheckAvailability(Models.AccountModels.Account a);
        AccountDetails GetAccountDetails(int? id);
        int GetUserId(Models.AccountModels.Account a);
        AccountDetails SaveChanges(Models.AccountModels.AccountDetails a);
    }
}
