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

        public static AccountDto AsDto(this Account account)
        {
            return new AccountDto()
            {
                Id = account.Id,
                Name = account.Name,
                AccountNo = account.AccountNo,
                User = account.User
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
                Account = expense.Account,
                User = expense.User,
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
                Account = income.Account,
                User = income.User,
                Amount = income.Amount
            };
        }
    }
}