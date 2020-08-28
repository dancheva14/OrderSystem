using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Status
    {
        public int StatusId { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
