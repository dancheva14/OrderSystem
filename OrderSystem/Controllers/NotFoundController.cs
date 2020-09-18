﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrderSystem.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult Index()
        {
           return RedirectToAction("Index", "Home");
        }
    }
}
