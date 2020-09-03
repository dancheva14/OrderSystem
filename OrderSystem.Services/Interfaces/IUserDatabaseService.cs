using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IUserDatabaseService
    {
        List<User> GetUsers();

        void UpdateRole(string id, string roleId);

        void DeleteUser(User user);
    }
}
