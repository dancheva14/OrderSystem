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
    public class OrdersController : Controller
    {
        IOrdersDatabaseService ordersService;

        public OrdersController(IOrdersDatabaseService ordersDatabaseService)
        {
            ordersService = ordersDatabaseService;
        }

        public IActionResult OrdersList(int orderId)
        {
            if (User.Identity.Name == null)
                return RedirectToAction("Login", "User");
            else
            {
                if (orderId == 0)
                {
                    var orders = ordersService.GetOrders().Where(o => o.User.UserName == User.Identity.Name);
                    return View(orders);
                }
                else
                {
                    List<Order> orders = new List<Order>();
                    orders.Add(ordersService.GetOrder(orderId));
                    return View(orders);
                }
            }
        }

        [HttpGet]
        public IActionResult EditOrder(int id)
        {
            OrderViewModel vm = new OrderViewModel();
            vm.Order = ordersService.GetOrder(id);
            vm.Status = vm.Order.Status;
            return View(vm);
        }

        [HttpPost]
        public IActionResult EditOrder(OrderViewModel vm)
        {
            var order = ordersService.GetOrder(vm.Order.OrderId);
            order.Status = null;
            order.StatusId = vm.Status.StatusId;
            ordersService.UpdateOrder(order);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult FindOrder()
        {
            // var orders = ordersService.GetOrders().Where(o => o.User.UserName == User.Identity.Name);
            return View();
        }

        [HttpPost]
        public IActionResult FindOrder(string number)
        {
            var order = ordersService.GetOrderByNumber(number);


            return RedirectToAction("OrdersList", "Orders", new { orderId = order.OrderId });
        }
    }
}
