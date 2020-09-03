using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.ViewModels
{
    public class StatusReportViewModel
    {
        public Status Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}
