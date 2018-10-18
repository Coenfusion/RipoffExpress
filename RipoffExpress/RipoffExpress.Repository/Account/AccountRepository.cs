using System;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.DAL.Account;

namespace RipoffExpress.Repository.Account
{
    public class AccountRepository
    {
        private AccountContext context = new AccountContext();

        public bool Login(AccountLogin a) => context.Login(a);
        public bool Register(AccountRegister a) => context.Register(a);
        public bool CheckAvailability(AccountRegister a) => context.CheckAvailability(a);
    }
}
