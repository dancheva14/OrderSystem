using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }
    }
}
