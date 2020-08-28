using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IPartnersDatabaseService
    {
        List<Partner> GetPartners();

        Partner GetPartner(int id);

        void AddPartner(Partner partner);

        void DeletePartner(Partner partner);

        void UpdatePartner(Partner partner);
    }
}
