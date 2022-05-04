using System;

namespace CashflowAPI.Models
{
    public record Account
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}