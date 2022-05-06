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

        // public UserRepository(DbConnection dbConnection)
        // {
        //     _dbConnection = dbConnection;
        // }

        public bool CreateUser(User user)
        {
            _dbConnection.Users.Add(user);
            _dbConnection.SaveChanges();

            return true;
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetUsers()
        {
            return _dbConnection.Users.AsNoTracking()
                .ToList();
        }
    }
}