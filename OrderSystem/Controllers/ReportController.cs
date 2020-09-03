using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
                return RedirectToAction("Login", "User");
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
                    viewModel.User = viewModel.Orders.FirstOrDefault().User;
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
                return RedirectToAction("Login", "User");
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
                return RedirectToAction("Login", "User");
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
                    viewModel.Status = viewModel.Orders.FirstOrDefault().Status;
                    return View(viewModel);
                }
            }
        }

        [HttpPost]
        public IActionResult StatusesReport(StatusReportViewModel viewModel)
        {
            return RedirectToAction("StatusReport", "Report", new { statusId = viewModel.Status.StatusId });
        }
    }
}
