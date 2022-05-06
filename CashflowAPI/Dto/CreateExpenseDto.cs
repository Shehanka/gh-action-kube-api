using System;

namespace CashflowAPI.Dto
{
    public record CreateExpenseDto
    {
        public Guid Id { get; init; }
        public string PaymentTo { get; init; }
        public string Description { get; init; }
        public string Category { get; init; }
        public string AccountId { get; init; }
        public string UserId { get; init; }
        public double Amount { get; init; }
    }
}