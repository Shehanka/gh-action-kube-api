using System;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public interface IUserRepository
    {
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(Guid id);
        User GetUser(Guid id);
    }
}