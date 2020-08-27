using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OrderSystem.Database.Models
{
    public class User : IdentityUser
    {
        [DisplayName("Име")]
        public string FirstName { get; set; }
        [DisplayName("Фамилия")]
        public string LastName { get; set; }
        [DisplayName("Телефон")]
        public override string PhoneNumber { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
