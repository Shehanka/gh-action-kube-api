using System;
using System.Collections.Generic;
using System.Linq;
using CashflowAPI.DB;
using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CashflowAPI.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly DbConnection _dbConnection = new DbConnection(
        );

        public bool CreateIncome(Income income)
        {
            _dbConnection.Incomes.Add(income);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool DeleteIncome(Guid userId, Guid incomeId)
        {
            var income = _dbConnection.Incomes.Find(incomeId);
            if (income is null)
            {
                return false;
            }

            _dbConnection.Incomes.Remove(income);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool UpdateIncome(Income income)
        {
            var incomeToUpdate = _dbConnection.Incomes.Find(income.Id);
            if (incomeToUpdate is null)
            {
                return false;
            }

            _dbConnection.Incomes.Update(income);
            _dbConnection.SaveChanges();
            return true;
        }

        public Income GetIncome(Guid userId, Guid incomeId)
        {
            return _dbConnection.Incomes.AsNoTracking()
                .SingleOrDefault(i => i.Id == incomeId);
        }

        public IEnumerable<Income> GetIncomes(Guid userId)
        {
            return _dbConnection.Incomes.AsNoTracking().ToList();
        }
    }
}