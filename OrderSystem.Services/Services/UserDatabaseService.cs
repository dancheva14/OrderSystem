using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

        public async Task UpdateRole(string id, string roleId)
        {
            var oldUser = await userManager.FindByIdAsync(id);

            await userManager.RemoveFromRoleAsync(oldUser, dbContext.Roles.FirstOrDefault(r=>r.Id != roleId).Name);
            await userManager.AddToRoleAsync(oldUser, dbContext.Roles.FirstOrDefault(r => r.Id == roleId).Name);

            dbContext.SaveChanges();

        }

        public void DeleteUser(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
    }
}
