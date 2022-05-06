using System;
using System.Collections.Generic;
using System.Linq;
using CashflowAPI.Dto;
using CashflowAPI.Models;
using CashflowAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CashflowAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpensesController : ControllerBase
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpensesController(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        // POST /expenses
        [HttpPost]
        public ActionResult<ExpenseDto> CreateExpense(CreateExpenseDto expenseDto)
        {
            Expense expense = new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTimeOffset.UtcNow,
                PaymentTo = expenseDto.PaymentTo,
                Description = expenseDto.Description,
                Category = expenseDto.Category,
                AccountId = expenseDto.AccountId,
                UserId = expenseDto.UserId,
                Amount = expenseDto.Amount
            };

            _expenseRepository.CreateExpense(expense);
            return CreatedAtAction(nameof(GetExpense), new {id = expense.Id}, expense.AsDto());
        }
        
        // PUT /expenses/{userId}/{expenseId}
        [HttpPut]
        public ActionResult UpdateExpense(Guid userId, Guid expenseId)
        {
            var existingExpense = _expenseRepository.GetExpense(userId, expenseId);
            if (existingExpense == null)
            {
                return NotFound();
            }

            Expense updatedExpense = existingExpense with
            {
                // TODO: Update expense implementation
            };
            
            _expenseRepository.UpdateExpense(updatedExpense);
            return NoContent();
        }

        // GET /expenses/{userId}/{expenseId}
        [HttpGet("{userId}/{expenseId}")]
        public ActionResult<ExpenseDto> GetExpense(Guid userId, Guid expenseId)
        {
            var expense = _expenseRepository.GetExpense(userId, expenseId).AsDto();
            if (expense == null)
            {
                return NotFound();
            }

            return expense;
        }

        // GET /expenses/{userId}
        [HttpGet("{userId}")]
        public IEnumerable<ExpenseDto> GetExpenses(Guid userId)
        {
            return _expenseRepository.GetExpenses(userId).Select(expense => expense.AsDto());
        }
        
        // DELETE /expenses/{userId}/{expenseId}
        [HttpDelete("{userId}/{expenseId}")]
        public ActionResult DeleteExpense(Guid userId, Guid expenseId)
        {
            var existingExpense = _expenseRepository.GetExpense(userId, expenseId);
            if (existingExpense == null)
            {
                return NotFound();
            }
            
            _expenseRepository.DeleteExpense(userId, expenseId);
            return NoContent();
        }
    }
}