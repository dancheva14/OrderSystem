﻿using OrderSystem.Database;
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
            return dbContext.Orders.ToList();
        }

        public Order GetOrder(int id)
        {
            return dbContext.Orders.FirstOrDefault(a => a.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var dbContextOrder = dbContext.Orders.FirstOrDefault(b => b.OrderId == order.OrderId);
            dbContextOrder = order;

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
            dbContextOrderDetail = orderDetail;

            dbContext.SaveChanges();
        }
    }
}
