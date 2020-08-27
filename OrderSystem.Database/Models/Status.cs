using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
