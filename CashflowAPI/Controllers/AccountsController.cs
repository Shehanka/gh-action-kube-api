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
    public class AccountsController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        // GET /accounts/{userId}
        [HttpGet("{userId}")]
        public IEnumerable<AccountDto> GetAccounts(Guid userId)
        {
            return _accountRepository.GetAccounts(userId).Select(account => account.AsDto());
        }

        // GET /accounts/{userId}/{accountId}
        [HttpGet("{userId}/{accountId}")]
        public ActionResult<AccountDto> GetAccount(Guid userId, Guid accountId)
        {
            var account = _accountRepository.GetAccount(userId, accountId).AsDto();
            if (account is null)
            {
                return NotFound();
            }

            return account;
        }

        // POST /accounts
        [HttpPost]
        public ActionResult<AccountDto> CreateAccount(AccountDto accountDto)
        {
            Account account = new()
            {
                Id = Guid.NewGuid(),
                Name = accountDto.Name,
                User = accountDto.User,
                AccountNo = accountDto.AccountNo,
            };

            _accountRepository.CreateAccount(account);
            return CreatedAtAction(nameof(GetAccount), new {userId = account.User.Id, accountId = account.Id},
                account.AsDto());
        }

        // PUT /accounts
        [HttpPut]
        public ActionResult UpdateAccount(Guid userId
        )
        {
            return Ok();
        }
    }
}