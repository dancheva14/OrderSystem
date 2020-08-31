using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class BrandDetail
    {
        public int BrandDetailId { get; set; }

        [Display(Name = "Тип на двигател")]
        public string EngineType { get; set; }

        [Display(Name = "К.с.")]
        public decimal Power { get; set; }

        [Display(Name = "Година на производство")]
        public int Year { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public virtual List<Part> Parts { get; set; }
    }
}
