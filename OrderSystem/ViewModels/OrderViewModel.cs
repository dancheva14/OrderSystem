using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace OrderSystem.ViewModels
{
    public class OrderViewModel
    {
        public Status Status { get; set; }

        public Order Order { get; set; }
    }
}
