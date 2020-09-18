using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using OrderSystem.ViewModels;

namespace OrderSystem.Controllers
{
    public class ReportController : Controller
    {

        IOrdersDatabaseService ordersService;

        public ReportController(IOrdersDatabaseService ordersDatabaseService)
        {
            ordersService = ordersDatabaseService;
        }

        public IActionResult UsersReport(string userId)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Index", "NotFound");
            else
            {
                UserReportViewModel viewModel = new UserReportViewModel();
                viewModel.Orders = new List<Order>();
                viewModel.User = new User();
                if (string.IsNullOrEmpty(userId))
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders());
                    viewModel.User = new User();
                    return View(viewModel);
                }
                else
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders().Where(o => o.UserId == userId));
                    if (viewModel.Orders.Count() > 0)
                        viewModel.User = viewModel.Orders?.FirstOrDefault().User;
                    else
                        viewModel.User = new User();
                    return View(viewModel);
                }
            }
        }

        [HttpPost]
        public IActionResult UsersReport(UserReportViewModel viewModel)
        {
            return RedirectToAction("UsersReport", "Report", new { userId = viewModel.User.Id });
        }

        public IActionResult DateReport(DateTime fromDate, DateTime toDate)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Index", "NotFound");
            else
            {
                DateReportViewModel viewModel = new DateReportViewModel();
                viewModel.Orders = new List<Order>();
                if (fromDate == DateTime.MinValue)
                {
                    viewModel.FromDate = new DateTime(DateTime.Now.Year, 1, 1);
                    viewModel.ToDate = new DateTime(DateTime.Now.Year, 12, 31);
                    viewModel.Orders.AddRange(ordersService.GetOrders());
                    return View(viewModel);
                }
                else
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders().Where(o => o.Date >= fromDate && o.Date <= toDate));
                    viewModel.FromDate = fromDate;
                    viewModel.ToDate = toDate;
                    return View(viewModel);
                }
            }
        }

        [HttpPost]
        public IActionResult DateReport(DateReportViewModel vm)
        {
            return RedirectToAction("DateReport", "Report", new { fromDate = vm.FromDate, toDate = vm.ToDate });
        }

        public IActionResult StatusReport(int statusId)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Index", "NotFound");
            else
            {
                StatusReportViewModel viewModel = new StatusReportViewModel();
                viewModel.Orders = new List<Order>();
                viewModel.Status = new Status();
                if (statusId == 0)
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders());
                    viewModel.Status = new Status();
                    return View(viewModel);
                }
                else
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders().Where(o => o.StatusId == statusId));
                    if (viewModel.Orders.Count() > 0)
                        viewModel.Status = viewModel.Orders.FirstOrDefault().Status;
                    else
                        viewModel.Status = new Status();

                    return View(viewModel);
                }
            }
        }

        [HttpPost]
        public IActionResult StatusesReport(StatusReportViewModel viewModel)
        {
            return RedirectToAction("StatusReport", "Report", new { statusId = viewModel.Status.StatusId });
        }

        public IActionResult PartnersReport(int partnerId)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Index", "NotFound");
            else
            {
                PartnerReportViewModel viewModel = new PartnerReportViewModel();
                viewModel.Orders = new List<Order>();
                viewModel.Partner = new Partner();
                viewModel.Partner.Name = string.Empty;

                if (partnerId == 0)
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders().Where(p => p.Partner != null));
                    return View(viewModel);
                }
                else
                {
                    viewModel.Orders.AddRange(ordersService.GetOrders().Where(o => o.PartnerId == partnerId));
                    if (viewModel.Orders.Count() > 0)
                        viewModel.Partner = viewModel.Orders?.FirstOrDefault().Partner;
                    return View(viewModel);
                }
            }
        }

        [HttpPost]
        public IActionResult PartnersReport(PartnerReportViewModel viewModel)
        {
            return RedirectToAction("PartnersReport", "Report", new { partnerId = viewModel.Partner.PartnerId });
        }
    }
}
