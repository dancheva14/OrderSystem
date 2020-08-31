using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        public virtual List<Part> Parts { get; set; }
    }
}
