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
        public AccountRepository(ContextType type)
        {
            switch (type)
            {
                case ContextType.MSSQLContext: context = new AccountContext(); break;
                case ContextType.MemoryContext: context = new AccountContext(); break;
            }
        }

        public bool Login(Models.AccountModels.Account a) => context.Login(a);
        public bool Register(Models.AccountModels.Account a) => context.Register(a);
        public bool CheckAvailability(Models.AccountModels.Account a) => context.CheckAvailability(a);
        public AccountDetails GetAccountDetails(int? Id) => context.GetAccountDetails(Id);
        public int GetUserId(Models.AccountModels.Account a) => context.GetUserId(a);
        public AccountDetails SaveChanges(AccountDetails a) => context.SaveChanges(a);
    }
}