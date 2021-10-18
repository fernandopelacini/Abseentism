using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Interfaces
{
public    interface IUser
    {
        Task<bool> AddUser(User user);
        Task<bool> EditUser(User user);
        Task<bool> IsValid(User user);
        Task<User> GetUser(string username);
        Task<bool> ValidateCredentials(string username, string password);

    }
}
