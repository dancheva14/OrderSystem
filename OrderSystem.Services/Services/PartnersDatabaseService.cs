using OrderSystem.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class PartnersDatabaseService : IPartnersDatabaseService
    {
        OrderSystemDbContext dbContext;
        public PartnersDatabaseService(OrderSystemDbContext dbcon)
        {
            dbContext = dbcon;
        }
    }
}
