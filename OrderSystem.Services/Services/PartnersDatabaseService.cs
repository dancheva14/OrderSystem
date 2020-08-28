using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Partner> GetPartners()
        {
            return dbContext.Partners.ToList();
        }

        public Partner GetPartner(int id)
        {
            return dbContext.Partners.FirstOrDefault(a => a.PartnerId == id);
        }

        public void AddPartner(Partner partner)
        {
            dbContext.Partners.Add(partner);
            dbContext.SaveChanges();
        }

        public void DeletePartner(Partner partner)
        {
            dbContext.Partners.Remove(partner);
            dbContext.SaveChanges();
        }

        public void UpdatePartner(Partner partner)
        {
            var dbContextPartner = dbContext.Partners.FirstOrDefault(b => b.PartnerId == partner.PartnerId);
            dbContextPartner = partner;

            dbContext.SaveChanges();
        }
    }
}
