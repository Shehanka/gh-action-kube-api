using System;
using CashflowAPI.Models;

namespace CashflowAPI.Dto
{
    public record IncomeDto
    {
        public Guid Id { get; init; }
        public string PaymentFrom { get; init; }
        public string Description { get; init; }
        public string Category { get; init; }
        public Account Account { get; init; }
        public User User { get; init; }
        public double Amount { get; init; }
        public DateTimeOffset CreatedDate { get; init; } 
    }
}