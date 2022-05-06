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
            _dbConnection.Expenses.Add(expense);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool DeleteExpense(Guid userId, Guid expenseId)
        {
            var expense = _dbConnection.Expenses.Find(expenseId);
            if (expense is null)
            {
                return false;
            }

            _dbConnection.Expenses.Remove(expense);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool UpdateExpense(Expense expense)
        {
            var expenseToUpdate = _dbConnection.Expenses.Find(expense.Id);
            if (expenseToUpdate is null)
            {
                return false;
            }

            _dbConnection.Expenses.Update(expense);
            _dbConnection.SaveChanges();
            return true;
        }

        public Expense GetExpense(Guid userId, Guid expenseId)
        {
            return _dbConnection.Expenses
                .AsNoTracking()
                .SingleOrDefault(e => e.Id == expenseId);
        }

        public IEnumerable<Expense> GetExpenses(Guid userId)
        {
            return _dbConnection.Expenses.AsNoTracking().ToList();
        }
    }
}