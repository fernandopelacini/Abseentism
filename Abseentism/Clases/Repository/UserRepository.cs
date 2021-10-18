using Abseentism.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Repository
{
    public class UserRepository : IUser
    {
        public Task<bool> AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsValid(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ValidateCredentials(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
