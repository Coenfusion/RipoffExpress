using System;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.DAL;
using RipoffExpress.DAL.Account;
using RipoffExpress.DAL.Interfaces;

namespace RipoffExpress.Repository.Account
{
    public class AccountRepository
    {
        private IAccountContext context;
        public AccountRepository(ContextTypes type)
        {
            switch (type)
            {
                case ContextTypes.MSSQLContext: context = new AccountContext(); break;
                case ContextTypes.MemoryContext: context = new AccountContext(); break;
            }
        }

        public bool Login(AccountLogin a) => context.Login(a);
        public bool Register(AccountRegister a) => context.Register(a);
        public bool CheckAvailability(AccountRegister a) => context.CheckAvailability(a);
        public AccountDetails GetAccountDetails(int Id) => context.GetAccountDetails(Id);
    }
}
