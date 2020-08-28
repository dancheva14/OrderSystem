using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IBrandsDatabaseService
    {
        List<Brand> GetBrands();

        Brand GetBrand(int id);

        List<BrandDetail> GetBrandDetails(int brandId);

        BrandDetail GetBrandDetail(int brandDetailId);

        void AddBrand(Brand brand);

        void AddBrandDetail(BrandDetail branddetail);

        void DeleteBrand(Brand brand);

        void DeleteBrandDetail(BrandDetail branddetail);

        void UpdateBrand(Brand brand);

        void UpdateBrandDetail(BrandDetail branddetail);
    }
}
