using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services.Interfaces
{
    public interface IUserDatabaseService
    {
        List<User> GetUsers();

        Task UpdateRole(string id, string roleId);

        void DeleteUser(User user);
    }
}
