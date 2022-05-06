using System;
using System.Collections.Generic;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public interface IAccountRepository
    {
        bool CreateAccount(Account account);
        bool DeleteAccount(Guid userId, Guid accountId);
        bool UpdateAccount(Account account);
        Account GetAccount(Guid userId, Guid accountId);
        IEnumerable<Account> GetAccounts(Guid userId);
    }
}