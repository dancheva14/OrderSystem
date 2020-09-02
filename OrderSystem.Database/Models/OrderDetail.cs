using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public int PartId { get; set; }
        public virtual Part Part { get; set; }

        [Display(Name = "Количество")]
        public int Quantity { get; set; }

        [Display(Name = "Цена")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
