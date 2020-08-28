using OrderSystem.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class OrdersDatabaseService : IOrdersDatabaseService
    {
        OrderSystemDbContext dbContext;
        public OrdersDatabaseService(OrderSystemDbContext dbcon)
        {
            dbContext = dbcon;
        }
    }
}
