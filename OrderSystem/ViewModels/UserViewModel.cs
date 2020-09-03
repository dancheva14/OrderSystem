using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public Role Role { get; set; }
    }
}
