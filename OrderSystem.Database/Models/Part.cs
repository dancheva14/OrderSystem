using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Part
    {
        public int PartId { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Цена")]
        public decimal Pricee { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BrandDetailId { get; set; }
        public BrandDetail BrandDetail { get; set; }
    }
}
