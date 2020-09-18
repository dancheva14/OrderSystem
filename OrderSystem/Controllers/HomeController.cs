using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderSystem.Models;
using OrderSystem.Services.Interfaces;

namespace OrderSystem.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBrandsDatabaseService BrandsService;
        public HomeController(ILogger<HomeController> logger, IBrandsDatabaseService BrandsDatabaseService)
        {
            _logger = logger;
            BrandsService = BrandsDatabaseService;
        }

        public IActionResult Index()
        {
            var Brands = BrandsService.GetBrands();
            var us = User.Identity.Name;

            return View(); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
