using Microsoft.EntityFrameworkCore;
using OrderSystem.Database;
using OrderSystem.Database.Models;
using OrderSystem.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderSystem.Services.Services
{
    public class OrdersDatabaseService : IOrdersDatabaseService
    {
        OrderSystemDbContext dbContext;
        public OrdersDatabaseService(OrderSystemDbContext dbcon)
        {
            dbContext = dbcon;
        }

        public List<Order> GetOrders()
        {
            return dbContext.Orders
                .Include(p => p.Partner)
                .Include(p => p.Status)
                .Include(p => p.User)
                .Include(p => p.OrderDetails).ThenInclude(p => p.Part).ToList();
        }

        public Order GetOrder(int id)
        {
            return GetOrders().FirstOrDefault(a => a.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            if (order != null)
            {
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
            }
        }

        public void DeleteOrder(Order order)
        {
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var dbContextOrder = GetOrder(order.OrderId);
            dbContextOrder.Address = order.Address;
            dbContextOrder.Amount = order.Amount;
            dbContextOrder.Date = order.Date;
            dbContextOrder.PartnerId = order.PartnerId;
            dbContextOrder.StatusId = order.StatusId;

            dbContext.SaveChanges();
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return dbContext.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return dbContext.OrderDetails.FirstOrDefault(a => a.OrderDetailId == id);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            dbContext.OrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            dbContext.OrderDetails.Remove(orderDetail);
            dbContext.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            var dbContextOrderDetail = dbContext.OrderDetails.FirstOrDefault(b => b.OrderDetailId == orderDetail.OrderDetailId);
            dbContextOrderDetail.Part = orderDetail.Part;
            dbContextOrderDetail.Price = orderDetail.Price;
            dbContextOrderDetail.Quantity = orderDetail.Quantity;

            dbContext.SaveChanges();
        }

        public Order GetOrderByNumber(string number)
        {
            var order = dbContext.Orders
                .Include(p => p.Partner)
                .Include(p => p.Status)
                .Include(p => p.User)
                .Include(p => p.OrderDetails).ThenInclude(p => p.Part).FirstOrDefault(a => a.Number == number);
            return order;
        }
    }
}
