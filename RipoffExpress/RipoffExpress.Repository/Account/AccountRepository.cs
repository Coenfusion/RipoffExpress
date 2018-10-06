﻿using System;
using RipoffExpress.Models.Models;
using RipoffExpress.DAL.Account;

namespace RipoffExpress.Repository.Account
{
    public class AccountRepository
    {
        private AccountContext context = new AccountContext();

        public bool Register(AccountRegister a) => context.Register(a);
        public bool CheckAvailability(AccountRegister a) => context.CheckAvailability(a);
    }
}
