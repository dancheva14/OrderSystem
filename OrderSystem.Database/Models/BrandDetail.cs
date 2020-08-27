using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class BrandDetail
    {
        public int BrandDetailId { get; set; }

        public string EngineType { get; set; }

        public decimal Power { get; set; }

        public int Year { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}
