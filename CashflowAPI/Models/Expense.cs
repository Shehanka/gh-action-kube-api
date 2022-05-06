using System;

namespace CashflowAPI.Models
{
    public record Expense
    {
        public Guid Id { get; init; }
        public DateTimeOffset CreatedDate { get; init; } 
    }
}