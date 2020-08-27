using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class Brand
    {
        public int BrandId { get; set; }

        public string Name { get; set; }

        public virtual List<BrandDetail> BrandDetails { get; set; }
    }
}
