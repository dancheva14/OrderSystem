using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using OrderSystem.ViewModels;

namespace OrderSystem.Controllers
{
    public class AdminManagment : Controller
    {
        ICategoryDatabaseService categoryService;
        IPartnersDatabaseService partnerService;
        IPartsDatabaseService partService;
        IStatusDatabaseService statusService;
        IBrandsDatabaseService brandService;

        public AdminManagment(ICategoryDatabaseService categorySer, IPartnersDatabaseService partnerSer, IPartsDatabaseService partSer
            , IStatusDatabaseService statusSer, IBrandsDatabaseService brandSer)
        {
            categoryService = categorySer;
            partnerService = partnerSer;
            partService = partSer;
            statusService = statusSer;
            brandService = brandSer;
        }

        #region Category
        [HttpGet]
        public IActionResult AddCategory()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categoryService.AddCategory(category);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Partner
        [HttpGet]
        public IActionResult AddPartner()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddPartner(Partner partner)
        {
            partnerService.AddPartner(partner);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region BrandDetail
        [HttpGet]
        public IActionResult AddBrandDetail()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddBrandDetail(BrandDetail brandDetail)
        {
            brandService.AddBrandDetail(brandDetail);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult GetBrandDetailsByBrandId(int stateid)
        {
            var details = brandService.GetBrandDetails(stateid);
            List<BrandDetailViewModel> vm = new List<BrandDetailViewModel>();
            foreach (var item in details)
            {
                var detail = string.Format("Двигател: {0}, к.с. {1}, година {2}", item.EngineType, item.Power, item.Year);
                vm.Add(new BrandDetailViewModel { Value = item.BrandDetailId, Text = detail });
            }

            SelectList obgcity = new SelectList(vm, "Value", "Text", 0);
            return Json(obgcity);
        }
        #endregion

        #region Brand
        [HttpGet]
        public IActionResult AddBrand()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            brandService.AddBrand(brand);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Status
        [HttpGet]
        public IActionResult AddStatus()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddStatus(Status status)
        {
            statusService.AddStatus(status);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Part
        [HttpGet]
        public IActionResult AddPart()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View();
        }

        [HttpPost]
        public IActionResult AddPart(Part part)
        {
            partService.AddPart(part);
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
