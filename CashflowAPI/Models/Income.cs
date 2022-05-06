using System;

namespace CashflowAPI.Models
{
    public record Income
    {
        public Guid Id { get; init; }
        public string PaymentFrom { get; init; }
        public string Description { get; init; }
        public string Category { get; init; }
        public string AccountId { get; init; }
        public string UserId { get; init; }
        public double Amount { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}