using System;
using CashflowAPI.Models;

namespace CashflowAPI.Dto
{
    public record ExpenseDto
    { 
        public Guid Id { get; init; }
        public string PaymentTo { get; init; }
        public string Description { get; init; }
        public string Category { get; init; }
        public Account Account { get; init; }
        public User User { get; init; }
        public double Amount { get; init; }
        public DateTimeOffset CreatedDate { get; init; } 
    }
}