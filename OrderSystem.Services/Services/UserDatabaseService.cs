using Microsoft.AspNetCore.Identity;
using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class UserDatabaseService : IUserDatabaseService
    {
        OrderSystemDbContext dbContext;
        private UserManager<User> userManager;

        public UserDatabaseService()
        {
            dbContext = new OrderSystemDbContext();
        }

        public UserDatabaseService(UserManager<User> urManager)
        {
            dbContext = new OrderSystemDbContext();
            userManager = urManager;
        }

        public List<User> GetUsers()
        {
            return dbContext.Users.ToList();
        }

        public void UpdateRole(string id, string roleId)
        {
            var user = dbContext.Users.FirstOrDefault(u => u.Id == id);
            var role = dbContext.Roles.FirstOrDefault(r => r.Id == roleId);
            userManager.AddToRoleAsync(user, role.Name).Wait();
            dbContext.SaveChanges();

            userManager.Dispose();
        }

        public void DeleteUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
