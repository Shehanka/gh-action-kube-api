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
    public class IncomesController : ControllerBase
    {
        private readonly IIncomeRepository _incomeRepository;

        public IncomesController(IIncomeRepository incomeRepository)
        {
            _incomeRepository = incomeRepository;
        }

        // GET /incomes/{userId}/{incomeId}
        [HttpGet("{userId}/{incomeId}")]
        public ActionResult<IncomeDto> GetIncome(Guid userId, Guid incomeId)
        {
            var income = _incomeRepository.GetIncome(userId, incomeId).AsDto();
            if (income == null)
            {
                return NotFound();
            }

            return income;
        }
        
        // GET /incomes/{userId}
        [HttpGet("{userId}")]
        public IEnumerable<IncomeDto> GetIncomes(Guid userId)
        {
            return _incomeRepository.GetIncomes(userId).Select(income => income.AsDto());
        }

        // POST /incomes
        [HttpPost]
        public ActionResult<IncomeDto> CreateIncome(CreateIncomeDto incomeDto)
        {
            Income income = new()
            {
                Id = Guid.NewGuid(),
                CreatedDate = DateTimeOffset.UtcNow,
                PaymentFrom = incomeDto.PaymentFrom,
                Description = incomeDto.Description,
                Category = incomeDto.Category,
                AccountId = incomeDto.AccountId,
                UserId = incomeDto.UserId,
                Amount = incomeDto.Amount
            };

            _incomeRepository.CreateIncome(income);
            return CreatedAtAction(nameof(GetIncome), new {id = income.Id}, income.AsDto());
        }
        
        // DELETE /incomes/{userId}/{incomeId}
        [HttpDelete]
        public ActionResult DeleteIncome(Guid userId, Guid incomeId)
        {
            var existingIncome = _incomeRepository.GetIncome(userId, incomeId);
            if (existingIncome == null)
            {
                return NotFound();
            }

            _incomeRepository.DeleteIncome(userId, incomeId);
            return NoContent();
        }
        
        // PUT /incomes/{user}
        // TODO: Impl Update Income
    }
}