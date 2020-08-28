using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class StatusDatabaseService : IStatusDatabaseService
    {
        OrderSystemDbContext dbContext;
        public StatusDatabaseService(OrderSystemDbContext dbcon)
        {
            dbContext = dbcon;
        }

        public List<Status> GetStatuss()
        {
            return dbContext.Statuses.ToList();
        }

        public Status GetStatus(int id)
        {
            return dbContext.Statuses.FirstOrDefault(a => a.StatusId == id);
        }
       
        public void AddStatus(Status status)
        {
            dbContext.Statuses.Add(status);
            dbContext.SaveChanges();
        }

        public void DeleteStatus(Status status)
        {
            dbContext.Statuses.Remove(status);
            dbContext.SaveChanges();
        }

        public void UpdateStatus(Status status)
        {
            var dbContextStatus = dbContext.Statuses.FirstOrDefault(b => b.StatusId == status.StatusId);
            dbContextStatus = status;

            dbContext.SaveChanges();
        }
    }
}

