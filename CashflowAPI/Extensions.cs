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
            };
        }
    }
}