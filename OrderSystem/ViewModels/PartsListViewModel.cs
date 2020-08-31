using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSystem.ViewModels
{
    public class PartsListViewModel
    {
        public int CategoryId { get; set; }

        public List<Part> Parts { get; set; }
    }
}
