using System;
using System.Collections.Generic;
using CashflowAPI.DB;
using CashflowAPI.Models;

namespace CashflowAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        private DbConnection dbConnection = new DbConnection();
        public bool CreateUser(User user)
        {
            throw new NotImplementedException();
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
            
            var usersData = dbConnection.Users;
            return usersData;
        }
    }
}