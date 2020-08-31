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
    public class PartsDatabaseService : IPartsDatabaseService
    {
        OrderSystemDbContext dbContext;
        public PartsDatabaseService(OrderSystemDbContext dbcon)
        {
            dbContext = dbcon;
        }
        public List<Part> GetParts()
        {
            return dbContext.Parts.Include(a => a.Category).Include(p => p.BrandDetail).ThenInclude(b => b.Brand).ToList();
        }

        public Part GetPart(int id)
        {
            return dbContext.Parts.FirstOrDefault(a => a.PartId == id);
        }

        public void AddPart(Part part)
        {
            dbContext.Parts.Add(part);
            dbContext.SaveChanges();
        }

        public void DeletePart(Part part)
        {
            dbContext.Parts.Remove(part);
            dbContext.SaveChanges();
        }

        public void UpdatePart(Part part)
        {
            var dbContextPart = dbContext.Parts.FirstOrDefault(b => b.PartId == part.PartId);
            dbContextPart.BrandDetail = part.BrandDetail;
            dbContextPart.BrandDetailId = part.BrandDetailId;
            dbContextPart.Category = part.Category;
            dbContextPart.CategoryId = part.CategoryId;
            dbContextPart.Name = part.Name;
            dbContextPart.Pricee = part.Pricee;

            dbContext.SaveChanges();
        }
    }
}
