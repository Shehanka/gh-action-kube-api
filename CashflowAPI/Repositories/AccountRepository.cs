using System;
using System.Collections.Generic;
using System.Linq;
using CashflowAPI.DB;
using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CashflowAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbConnection _dbConnection = new DbConnection(
        );

        public bool CreateAccount(Account account)
        {
            _dbConnection.Accounts.Add(account);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool DeleteAccount(Guid userId, Guid accountId)
        {
            var account = _dbConnection.Accounts.Find(accountId);
            if (account is null)
            {
                return false;
            }

            _dbConnection.Accounts.Remove(account);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool UpdateAccount(Account account)
        {
            var accountToUpdate = _dbConnection.Accounts.Find(account.Id);
            if (accountToUpdate is null)
            {
                return false;
            }

            _dbConnection.Accounts.Update(account);
            _dbConnection.SaveChanges();
            return true;
        }

        public Account GetAccount(Guid userId, Guid accountId)
        {
            return _dbConnection.Accounts.AsNoTracking()
                .SingleOrDefault(a => a.Id == accountId);
        }

        public IEnumerable<Account> GetAccounts(Guid userId)
        {
            return _dbConnection.Accounts.AsNoTracking().ToList();
        }
    }
}