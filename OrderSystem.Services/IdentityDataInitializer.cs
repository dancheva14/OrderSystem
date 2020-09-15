using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Services
{
    public static class IdentityDataInitializer
    {
        public static async Task SeedData(UserManager<User> userManager,
         RoleManager<Role> roleManager,
         IRoleDatabaseService roleDatabaseService
            ,IUserDatabaseService userDatabaseService
            ,IPartnersDatabaseService partnersDatabase
            ,IBrandsDatabaseService brandsDatabaseService
            ,ICategoryDatabaseService categoryDatabaseService
            ,IStatusDatabaseService statusDatabaseService)
        {
            await SeedRoles(roleManager, roleDatabaseService);
            //await SeedData(userDatabaseService, partnersDatabase, brandsDatabaseService, categoryDatabaseService, statusDatabaseService);

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

        public static async Task SeedData(IUserDatabaseService userDatabaseService
            , IPartnersDatabaseService partnersDatabase
            , IBrandsDatabaseService brandsDatabaseService
            , ICategoryDatabaseService categoryDatabaseService
            , IStatusDatabaseService statusDatabaseService)
        {
            if(partnersDatabase.GetPartners().Count == 0)
            {
                Partner partner = new Partner();
                partner.Name = "Валкит ЛТД ЕООД";
                partner.Bulstat = "6592345675";
                partnersDatabase.AddPartner(partner);
            }

            if(brandsDatabaseService.GetBrands().Count == 0)
            {
                Brand brand = new Brand();
                brand.Name = "БМВ";
                BrandDetail brandDetail = new BrandDetail();
                brandDetail.EngineType = "дизел";
                brandDetail.Year = 2012;
                brandDetail.Power = 116;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brandDetail.EngineType = "бензин";
                brandDetail.Year = 2019;
                brandDetail.Power = 240;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brand = new Brand();
                brand.Name = "АУДИ";
                brandDetail.EngineType = "бензин";
                brandDetail.Year = 2008;
                brandDetail.Power = 109;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brand = new Brand();
                brand.Name = "Хюндай";
                brandDetail.EngineType = "дизел";
                brandDetail.Year = 2015;
                brandDetail.Power = 109;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brand.Name = "Мерцедес";
                brandDetail.EngineType = "газ";
                brandDetail.Year = 2011;
                brandDetail.Power = 142;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brandDetail.EngineType = "дизел";
                brandDetail.Year = 2004;
                brandDetail.Power = 109;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                brand.Name = "Пежо";
                brandDetail.EngineType = "бензин";
                brandDetail.Year = 2008;
                brandDetail.Power = 109;
                brandDetail.Brand = brand;
                brandsDatabaseService.AddBrandDetail(brandDetail);

                Category category = new Category();
                category.Name = "Аксесоари";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Спирачни дискове";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Гуми";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Накладки";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Автохимия";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Крушки за фарове";
                categoryDatabaseService.AddCategory(category);
                category.Name = "Други";
                categoryDatabaseService.AddCategory(category);

                Status status = new Status();
                status.Name = "Очаква се обработка";
                statusDatabaseService.AddStatus(status);
                status.Name = "Получена в офис";
                statusDatabaseService.AddStatus(status);
                status.Name = "Изпратена от доставчик";
                statusDatabaseService.AddStatus(status);
                status.Name = "Изпратена";
                statusDatabaseService.AddStatus(status);
                status.Name = "Получена";
                statusDatabaseService.AddStatus(status);
                status.Name = "Пренасочена към друг адрес";
                statusDatabaseService.AddStatus(status);

            }
        }
    }
}
