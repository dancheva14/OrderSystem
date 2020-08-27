using OrderSystem.Database;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}
