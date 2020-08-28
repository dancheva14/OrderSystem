using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface ICategoryDatabaseService
    {
        List<Category> GetCategorys();

        Category GetCategory(int id);

        void AddCategory(Category category);

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);
    }
}

