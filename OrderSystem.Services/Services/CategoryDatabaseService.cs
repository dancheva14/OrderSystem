using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class CategoryDatabaseService : ICategoryDatabaseService
    {
        OrderSystemDbContext dbContext;
        public CategoryDatabaseService()
        {
            dbContext = new OrderSystemDbContext();
        }

        public void AddCategory(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            dbContext.Categories.Remove(category);
            dbContext.SaveChanges();
        }

        public Category GetCategory(int id)
        {
            return dbContext.Categories.FirstOrDefault(a => a.CategoryId == id);
        }

        public List<Category> GetCategorys()
        {
            return dbContext.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            var dbContextCategory = dbContext.Categories.FirstOrDefault(b => b.CategoryId == category.CategoryId);
            dbContextCategory.Name = category.Name;

            dbContext.SaveChanges();
        }
    }
}
