using System;
using System.Collections.Generic;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public interface IExpenseRepository
    {
        bool CreateExpense(Expense expense);
        bool DeleteExpense(Guid userId, Guid expenseId);
        bool UpdateExpense(Expense expense);
        Expense GetExpense(Guid userId, Guid expenseId);
        IEnumerable<Expense> GetExpenses(Guid userId);
    }
}