using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Partner
    {
        public int PartnerId { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Булстат")]
        public string Bulstat { get; set; }

        public List<Order> Orders { get; set; }
    }
}
