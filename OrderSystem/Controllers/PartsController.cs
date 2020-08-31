using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Services.Interfaces;
using OrderSystem.ViewModels;

namespace OrderSystem.Controllers
{
    public class PartsController : Controller
    {
        IPartsDatabaseService partsService;
        public PartsController(IPartsDatabaseService partsDatabaseService)
        {
            partsService = partsDatabaseService;
        }
        public IActionResult PartsList()
        {
            var parts = partsService.GetParts();

            var partsVM = new PartsListViewModel();
            partsVM.Parts = new List<Database.Models.Part>();

            partsVM.Parts.AddRange(parts);

            return View(partsVM);
        }

        [HttpPost]
        public IActionResult PartsList(PartsListViewModel viewModel)
        {
            var parts = partsService.GetParts().Where(p=>p.CategoryId == viewModel.CategoryId || viewModel.CategoryId == 0);

            var partsVM = new PartsListViewModel();
            partsVM.Parts = new List<Database.Models.Part>();

            partsVM.Parts.AddRange(parts);

            return View(partsVM);
        }
        
        [HttpPost]
        public IActionResult AddToCart(int itemId = 0)
        {
            string id = string.Empty ;
            if (TempData["itemsToCart"] != null)
                id = TempData["itemsToCart"].ToString();

            id += "," + itemId;

            TempData["itemsToCart"] = id;

            return RedirectToAction("PartsList", "Parts");
        }
    }
}
