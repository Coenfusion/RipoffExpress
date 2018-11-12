using System;
using RipoffExpress.Models.AccountModels;

namespace RipoffExpress.DAL.Interfaces
{
    public interface IAccountContext
    {
        bool Login(AccountLogin a);
        bool Register(AccountRegister a);
        bool CheckAvailability(AccountRegister a);
        AccountDetails GetAccountDetails(int id);
    }
}
