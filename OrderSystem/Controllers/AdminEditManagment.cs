using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using OrderSystem.ViewModels;


namespace OrderSystem.Controllers
{
    public class AdminEditManagment : Controller
    {
        ICategoryDatabaseService categoryService;
        IPartnersDatabaseService partnerService;
        IPartsDatabaseService partService;
        IStatusDatabaseService statusService;
        IBrandsDatabaseService brandService;

        public AdminEditManagment(ICategoryDatabaseService categorySer, IPartnersDatabaseService partnerSer, IPartsDatabaseService partSer
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
        public IActionResult GetListCategory()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(categoryService.GetCategorys());
        }

        [HttpGet]
        public IActionResult EditCategory(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(categoryService.GetCategory(id));
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            categoryService.DeleteCategory(category);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Partner

        [HttpGet]
        public IActionResult GetListPartner()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(partnerService.GetPartners());
        }

        [HttpGet]
        public IActionResult EditPartner(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(partnerService.GetPartner(id));
        }

        [HttpPost]
        public IActionResult EditPartner(Partner partner)
        {
            partnerService.UpdatePartner(partner);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeletePartner(Partner partner)
        {
            partnerService.DeletePartner(partner);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region BrandDetail
        [HttpGet]
        public IActionResult GetListBrandDetail()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(brandService.GetAllBrandDetails());
        }

        [HttpGet]
        public IActionResult EditBrandDetail(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(brandService.GetBrandDetail(id));
        }

        [HttpPost]
        public IActionResult EditBrandDetail(BrandDetail brandDetail)
        {
            brandService.UpdateBrandDetail(brandDetail);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeleteBrandDetail(BrandDetail brandDetail)
        {
            brandService.DeleteBrandDetail(brandDetail);
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
        public IActionResult EditBrand(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(brandService.GetBrand(id));
        }

        [HttpGet]
        public IActionResult GetListBrands()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(brandService.GetBrands());
        }

        [HttpPost]
        public IActionResult EditBrand(Brand brand)
        {
            brandService.UpdateBrand(brand);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeleteBrand(Brand brand)
        {
            brandService.DeleteBrand(brand);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Status

        [HttpGet]
        public IActionResult GetListStatus()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(statusService.GetStatuss());
        }

        [HttpGet]
        public IActionResult EditStatus(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(statusService.GetStatus(id));
        }

        [HttpPost]
        public IActionResult EditStatus(Status status)
        {
            statusService.UpdateStatus(status);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeleteStatus(Status status)
        {
            statusService.DeleteStatus(status);
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Part
        [HttpGet]
        public IActionResult GetListPart()
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(partService.GetParts());
        }

        [HttpGet]
        public IActionResult EditPart(int id = 0)
        {

            //var user = User.Identity.Name;
            //if (user == null)
            //    return RedirectToAction("Login", "User");
            //else
            return View(partService.GetPart(id));
        }

        [HttpPost]
        public IActionResult EditPart(Part part)
        {
            partService.UpdatePart(part);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult DeletePart(Part part)
        {
            partService.DeletePart(part);
            return RedirectToAction("Index", "Home");
        }
        #endregion
    }
}
