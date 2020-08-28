using Microsoft.EntityFrameworkCore;
using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class BrandsDatabaseService : IBrandsDatabaseService
    {
        OrderSystemDbContext dbContext;
        public BrandsDatabaseService()
        {
            dbContext = new OrderSystemDbContext();
        }
        public List<Brand> GetBrands()
        {
            return dbContext.Brands.ToList();
        }

        public Brand GetBrand(int id)
        {
            return dbContext.Brands.FirstOrDefault(a=>a.BrandId == id);
        }

        public List<BrandDetail> GetBrandDetails(int brandId)
        {
            return dbContext.BrandDetails.Where(b => b.BrandId == brandId).ToList();
        }
        public BrandDetail GetBrandDetail(int brandDetailId)
        {
            return dbContext.BrandDetails.FirstOrDefault(b => b.BrandDetailId == brandDetailId);
        }

        public List<BrandDetail> GetAllBrandDetails()
        {
            return dbContext.BrandDetails.ToList();
        }

        public void AddBrand(Brand brand)
        {
            dbContext.Brands.Add(brand);
            dbContext.SaveChanges();
        }

        public void AddBrandDetail(BrandDetail branddetail)
        {
            dbContext.BrandDetails.Add(branddetail);
            dbContext.SaveChanges();
        }

        public void DeleteBrand(Brand brand)
        {
            dbContext.Brands.Remove(brand);
            dbContext.SaveChanges();
        }

        public void DeleteBrandDetail(BrandDetail branddetail)
        {
            dbContext.BrandDetails.Remove(branddetail);
            dbContext.SaveChanges();
        }

        public void UpdateBrand(Brand brand)
        {
            var dbContextBrand = dbContext.Brands.FirstOrDefault(b => b.BrandId == brand.BrandId);
            dbContextBrand.Name = brand.Name;

            dbContext.SaveChanges();
        }

        public void UpdateBrandDetail(BrandDetail branddetail)
        {
            var dbContextbranddetail = dbContext.BrandDetails.FirstOrDefault(b => b.BrandDetailId == branddetail.BrandDetailId);
            dbContextbranddetail.BrandId = branddetail.BrandId;
            dbContextbranddetail.EngineType = branddetail.EngineType;
            dbContextbranddetail.Power = branddetail.Power;
            dbContextbranddetail.Year = branddetail.Year;

            dbContext.SaveChanges();
        }
    }
}
