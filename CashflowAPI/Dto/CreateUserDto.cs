using System.ComponentModel.DataAnnotations;

namespace CashflowAPI.Dto
{
    public record CreateUserDto
    {
        [Required]
        public string Username { get; init; }
        
        [Required]
        public string FirstName { get; init; }
        
        [Required]
        public string LastName { get; init; }
        
        [Required]
        public string Password { get; init; }
        
        [Required]
        public string Email { get; init; }
    }
}