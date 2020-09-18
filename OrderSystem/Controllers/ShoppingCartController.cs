using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;

namespace OrderSystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        IPartsDatabaseService partsService;
        IOrdersDatabaseService ordersService;
        IPartnersDatabaseService partnerService;
        IStatusDatabaseService statusService;
        IUserDatabaseService userService;

        public ShoppingCartController(IPartsDatabaseService partsDatabaseService, IOrdersDatabaseService ordersDatabaseService
            , IPartnersDatabaseService partnersDatabase, IStatusDatabaseService statusDatabase, IUserDatabaseService usDatabase)
        {
            partsService = partsDatabaseService;
            ordersService = ordersDatabaseService;
            partnerService = partnersDatabase;
            statusService = statusDatabase;
            userService = usDatabase;
        }

        public IActionResult Cart()
        {
            Random random = new Random();
            var order = new Order();
            order.OrderDetails = new List<OrderDetail>();

            if (User.Identity.Name == null)
                return RedirectToAction("Index", "NotFound");
            else
            {
                var ids = HttpContext.Session.GetString("itemsToCart");
                if (!string.IsNullOrEmpty(ids))
                {
                    var parts = partsService.GetPartsByIds(ids.ToString());
                    foreach (var part in parts)
                    {
                        order.OrderDetails.Add(new OrderDetail { Part = part, Price = part.Pricee, Quantity = 1 });
                    }
                    order.Number = random.Next(1000, 100000).ToString();

                    return View(order);
                }
                else
                {
                    return View(order);
                }
            }
        }

        [HttpPost]
        public IActionResult Cart(Order order)
        {
            var newOrder = new Order();
            newOrder.OrderDetails = new List<OrderDetail>();
            Random random = new Random();
            foreach (var orderDetail in order.OrderDetails)
            {
                newOrder.OrderDetails.Add(new OrderDetail { PartId = orderDetail.Part.PartId, Price = orderDetail.Part.Pricee, Quantity = orderDetail.Quantity, Part = null });
            }
            newOrder.Number = random.Next(1000, 100000).ToString();
            newOrder.Date = DateTime.Now;
            newOrder.Amount = order.OrderDetails.Sum(a => a.Price * a.Quantity);
            newOrder.PartnerId = order.PartnerId;
            newOrder.Address = order.Address;
            newOrder.StatusId = statusService.GetStatuss().FirstOrDefault().StatusId;
            newOrder.UserId = userService.GetUsers().FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            newOrder.Partner = null;
            newOrder.Status = null;
            newOrder.User = null;

            ordersService.AddOrder(newOrder);

            HttpContext.Session.SetString("itemsToCart", string.Empty);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var ids = HttpContext.Session.GetString("itemsToCart");

            if (id != 0)
            {
                List<string> idArr = ids.Split(",").ToList();

                idArr.Remove(id.ToString());
                string newIds = string.Empty;
                foreach (var item in idArr)
                {
                    if (!string.IsNullOrEmpty(newIds))
                        newIds += "," + item;
                    else
                        newIds = item;
                }

                HttpContext.Session.SetString("itemsToCart", newIds);
            }

            return RedirectToAction("Cart", "ShoppingCart");
        }

        [HttpPost]
        public IActionResult Order(Order order)
        {
            var ids = HttpContext.Session.GetString("itemsToCart");
            if (!string.IsNullOrEmpty(ids))
            {
                Random random = new Random();
                var parts = partsService.GetPartsByIds(ids.ToString());
                order.OrderDetails = new List<OrderDetail>();
                foreach (var part in parts)
                {
                    order.OrderDetails.Add(new OrderDetail { Part = part, Price = part.Pricee, Quantity = 1 });
                }
                order.Number = random.Next(1000, 100000).ToString();
            }

            ordersService.AddOrder(order);

            HttpContext.Session.SetString("itemsToCart", string.Empty);

            return RedirectToAction("Index", "Home");
        }
    }
}
