using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrderSystem.Database.Models
{
   public class Order
    {
        public int OrderId { get; set; }

        public string Number { get; set; }

        [Display(Name = "Дата")]
        public DateTime Date { get; set; }

        [Display(Name = "Стойност")]
        public decimal Amount { get; set; }

        [Display(Name = "Адрес")]
        public string Address { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        public int PartnerId { get; set; }

        public virtual Partner Partner { get; set; }

        public string UserId { get; set; }

        public virtual User User{ get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
