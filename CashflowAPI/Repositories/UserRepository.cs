using System;
using System.Collections.Generic;
using System.Linq;
using CashflowAPI.DB;
using CashflowAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CashflowAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbConnection _dbConnection = new DbConnection();

        public bool CreateUser(User user)
        {
            _dbConnection.Users.Add(user);
            _dbConnection.SaveChanges();

            return true;
        }

        public bool UpdateUser(User user)
        {
            var userUpdate = _dbConnection.Users.Find(user.Id);
            if (userUpdate is null)
            {
                return false;
            }

            _dbConnection.Users.Update(user);
            _dbConnection.SaveChanges();
            return true;
        }

        public bool DeleteUser(Guid id)
        {
            var user = _dbConnection.Users.Find(id);
            if (user is null)
            {
                return false;
            }

            _dbConnection.Users.Remove(user);
            _dbConnection.SaveChanges();
            return true;
        }

        public User GetUser(Guid id)
        {
            return _dbConnection.Users
                .Include(u => u.Username)
                .Include(u => u.FirstName)
                .Include(u => u.LastName)
                .Include(u => u.Email)
                .Include(u => u.CreatedDate)
                .AsNoTracking().SingleOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbConnection.Users.AsNoTracking()
                .ToList();
        }
    }
}