using System;
using System.Linq;
using CashflowAPI.Dto;
using CashflowAPI.Models;
using CashflowAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CashflowAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // POST /users
        [HttpPost]
        public ActionResult<UserDto> CreateUser(CreateUserDto userDto)
        {
            User user = new()
            {
                Id = Guid.NewGuid(),
                Username = userDto.Username,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Password = userDto.Password,
                Email = userDto.Email,
                CreatedDate = DateTimeOffset.UtcNow
            };

            _userRepository.CreateUser(user);

            return CreatedAtAction(nameof(GetUser), new {id = user.Id}, user.AsDto());
        }

        // GET /users/{id}
        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser(Guid id)
        {
            User user = _userRepository.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }

            return new UserDto
            {
                Id = user.Id,
                Username = user.Username,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}