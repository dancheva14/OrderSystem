using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IBrandsDatabaseService
    {
        List<Brand> GetBrands();
    }
}
