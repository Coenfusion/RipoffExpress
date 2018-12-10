using System;
using RipoffExpress.Models.AccountModels;
using RipoffExpress.DAL;
using RipoffExpress.DAL.Interfaces;

namespace RipoffExpress.Repository
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

        public bool Login(Account a) => context.Login(a);
        public void Register(Account a) => context.Register(a);
        public bool CheckAvailability(Account a) => context.CheckAvailability(a);
        public AccountDetails GetAccountDetails(int? Id) => context.GetAccountDetails(Id);
        public int GetUserId(Account a) => context.GetUserId(a);
        public void SaveChanges(AccountChanges a, int? Id) => context.SaveChanges(a, Id);
    }
}