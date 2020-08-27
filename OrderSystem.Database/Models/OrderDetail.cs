using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int PartId { get; set; }
        public Part Part { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
