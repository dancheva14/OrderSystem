using Microsoft.AspNetCore.Identity;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services
{
    public static class IdentityDataInitializer
    {
        public static async Task SeedData(UserManager<User> userManager,
         RoleManager<Role> roleManager,
         IRoleDatabaseService roleDatabaseService)
        {
            await SeedRoles(roleManager, roleDatabaseService);

        }

        public static async Task SeedRoles(RoleManager<Role> roleManager,
            IRoleDatabaseService roleDatabaseService)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                Role role = new Role();
                role.Name = "User";
                await roleManager.CreateAsync(role);
            }
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                Role role = new Role();
                role.Name = "Admin";
                await roleManager.CreateAsync(role);
            }
        }
    }
}
