using System;
using CashflowAPI.Models;

namespace CashflowAPI.Dto
{
    public record CreateIncomeDto
    {
        public Guid Id { get; init; }
        public string PaymentFrom { get; init; }
        public string Description { get; init; }
        public string Category { get; init; }
        public Guid AccountId { get; init; }
        public Guid UserId { get; init; }
        public double Amount { get; init; }
    }
}