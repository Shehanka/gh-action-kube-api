using System;
using System.Collections.Generic;
using System.Linq;
using CashflowAPI.DB;
using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CashflowAPI.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DbConnection _dbConnection = new DbConnection(
        );

        public bool CreateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public bool DeleteExpense(Guid userId, Guid expenseId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public Expense GetExpense(Guid userId, Guid expenseId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Expense> GetExpenses(Guid userId)
        {
            return _dbConnection.Expenses.AsNoTracking().ToList();
        }
    }
}