using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderSystem.Controllers
{
    public class AdminManagment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
