using System;
using System.Collections.Generic;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public interface IIncomeRepository
    {
        bool CreateIncome(Income income);
        bool DeleteIncome(Guid userId, Guid incomeId);
        bool UpdateIncome(Income income);
        Income GetIncome(Guid userId, Guid incomeId);
        IEnumerable<Income> GetIncomes(Guid userId);
    }
}