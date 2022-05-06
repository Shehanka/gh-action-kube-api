using CashflowAPI.Dto;
using CashflowAPI.Models;

namespace CashflowAPI
{
    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
            return new UserDto()
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                CreatedDate = user.CreatedDate
            };
        }

        public static ExpenseDto AsDto(this Expense expense)
        {
            return new ExpenseDto()
            {
                Id = expense.Id,
                CreatedDate = expense.CreatedDate,
                PaymentTo = expense.PaymentTo,
                Description = expense.Description,
                Category = expense.Category,
                AccountId = expense.AccountId,
                UserId = expense.UserId,
                Amount = expense.Amount
            };
        }

        public static IncomeDto AsDto(this Income income)
        {
            return new IncomeDto()
            {
                Id = income.Id,
                CreatedDate = income.CreatedDate,
                PaymentFrom = income.PaymentFrom,
                Description = income.Description,
                Category = income.Category,
                AccountId = income.AccountId,
                UserId = income.UserId,
                Amount = income.Amount
            };
        }
    }
}