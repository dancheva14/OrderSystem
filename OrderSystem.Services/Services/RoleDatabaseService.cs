using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class RoleDatabaseService : IRoleDatabaseService
    {
        OrderSystemDbContext dbContext;

        public RoleDatabaseService()
        {
            dbContext = new OrderSystemDbContext();
        }

        public void Add(Role role)
        {
            dbContext.Roles.Add(role);
            dbContext.SaveChanges();
        }

        public List<Role> GetRoles()
        {
            return dbContext.Roles.ToList();
        }
    }
}
