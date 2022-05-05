using System;
using System.Collections.Generic;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
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
            throw new NotImplementedException();
        }
    }
}