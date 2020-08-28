using OrderSystem.Database;
using System;
using System.Collections.Generic;
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
    }
}
