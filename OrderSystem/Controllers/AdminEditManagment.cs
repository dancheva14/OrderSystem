using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        IUserDatabaseService userService;

        public AdminEditManagment(ICategoryDatabaseService categorySer, IPartnersDatabaseService partnerSer, IPartsDatabaseService partSer
            , IStatusDatabaseService statusSer, IBrandsDatabaseService brandSer, IUserDatabaseService userDatabaseService)
        {
            categoryService = categorySer;
            partnerService = partnerSer;
            partService = partSer;
            statusService = statusSer;
            brandService = brandSer;
            userService = userDatabaseService;
        }

        #region Category

        [HttpGet]
        public IActionResult GetListCategory()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(categoryService.GetCategorys());
        }

        [HttpGet]
        public IActionResult EditCategory(int id = 0)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(categoryService.GetCategory(id));
        }

        [HttpPost]
        public IActionResult EditCategory(Category category)
        {
            categoryService.UpdateCategory(category);
            return RedirectToAction("GetListCategory", "AdminEditManagment");
        }
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            categoryService.DeleteCategory(category);
            return RedirectToAction("GetListCategory", "AdminEditManagment");
        }
        #endregion

        #region Partner

        [HttpGet]
        public IActionResult GetListPartner()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(partnerService.GetPartners());
        }

        [HttpGet]
        public IActionResult EditPartner(int id = 0)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(partnerService.GetPartner(id));
        }

        [HttpPost]
        public IActionResult EditPartner(Partner partner)
        {
            partnerService.UpdatePartner(partner);
            return RedirectToAction("GetListPartner", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeletePartner(Partner partner)
        {
            partnerService.DeletePartner(partner);
            return RedirectToAction("GetListPartner", "AdminEditManagment");
        }
        #endregion

        #region BrandDetail
        [HttpGet]
        public IActionResult GetListBrandDetail()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(brandService.GetAllBrandDetails());
        }

        [HttpGet]
        public IActionResult EditBrandDetail(int id = 0)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(brandService.GetBrandDetail(id));
        }

        [HttpPost]
        public IActionResult EditBrandDetail(BrandDetail brandDetail)
        {
            brandService.UpdateBrandDetail(brandDetail);
            return RedirectToAction("GetListBrandDetail", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeleteBrandDetail(BrandDetail brandDetail)
        {
            brandService.DeleteBrandDetail(brandDetail);
            return RedirectToAction("GetListBrandDetail", "AdminEditManagment");
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
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(brandService.GetBrand(id));
        }

        [HttpGet]
        public IActionResult GetListBrands()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(brandService.GetBrands());
        }

        [HttpPost]
        public IActionResult EditBrand(Brand brand)
        {
            brandService.UpdateBrand(brand);
            return RedirectToAction("GetListBrands", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeleteBrand(Brand brand)
        {
            brandService.DeleteBrand(brand);
            return RedirectToAction("GetListBrands", "AdminEditManagment");
        }
        #endregion

        #region Status

        [HttpGet]
        public IActionResult GetListStatus()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(statusService.GetStatuss());
        }

        [HttpGet]
        public IActionResult EditStatus(int id = 0)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(statusService.GetStatus(id));
        }

        [HttpPost]
        public IActionResult EditStatus(Status status)
        {
            statusService.UpdateStatus(status);
            return RedirectToAction("GetListStatus", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeleteStatus(Status status)
        {
            statusService.DeleteStatus(status);
            return RedirectToAction("GetListStatus", "AdminEditManagment");
        }
        #endregion

        #region Part
        [HttpGet]
        public IActionResult GetListPart()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(partService.GetParts());
        }

        [HttpGet]
        public IActionResult EditPart(int id = 0)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(partService.GetPart(id));
        }

        [HttpPost]
        public IActionResult EditPart(Part part)
        {
            partService.UpdatePart(part);
            return RedirectToAction("GetListPart", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeletePart(Part part)
        {
            partService.DeletePart(part);
            return RedirectToAction("GetListPart", "AdminEditManagment");
        }
        #endregion

        #region User

        [HttpGet]
        public IActionResult GetListUser()
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
                return View(userService.GetUsers());
        }

        [HttpGet]
        public IActionResult EditUser(string id)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
            {
                var user = userService.GetUsers().FirstOrDefault(u => u.Id == id);
                UserViewModel vm = new UserViewModel();
                vm.User = user;
                return View(vm);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserViewModel userVm)
        {
            await userService.UpdateRole(userVm.User.Id, userVm.Role.Id);
            return RedirectToAction("GetListUser", "AdminEditManagment");
        }

        [HttpPost]
        public IActionResult DeleteUser(User user)
        {
            userService.DeleteUser(user);
            return RedirectToAction("GetListUser", "AdminEditManagment");
        }
        #endregion
    }
}
