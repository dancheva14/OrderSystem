using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }

        public string Name { get; set; }

        public string Bulstat { get; set; }

        public List<Order> Orders { get; set; }
    }
}
