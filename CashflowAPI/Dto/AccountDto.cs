using System;
using CashflowAPI.Models;

namespace CashflowAPI.Dto
{
    public record AccountDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public Int64 AccountNo { get; init; }
        public User User { get; init; }
    }
}