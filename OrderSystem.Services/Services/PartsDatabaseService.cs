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
            return dbContext.Parts.ToList();
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
            dbContextPart = part;

            dbContext.SaveChanges();
        }
    }
}
