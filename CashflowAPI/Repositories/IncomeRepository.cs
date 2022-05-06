using System;
using System.Collections.Generic;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        public bool CreateIncome(Income income)
        {
            throw new NotImplementedException();
        }

        public bool DeleteIncome(Guid userId, Guid incomeId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateIncome(Income income)
        {
            throw new NotImplementedException();
        }

        public Income GetIncome(Guid userId, Guid incomeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Income> GetIncomes(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}