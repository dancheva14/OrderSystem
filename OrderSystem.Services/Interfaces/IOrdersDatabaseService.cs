using OrderSystem.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Services.Interfaces
{
    public interface IOrdersDatabaseService
    {
        List<Order> GetOrders();

        Order GetOrder(int id);

        Order GetOrderByNumber(string number);

        void AddOrder(Order order);

        void DeleteOrder(Order order);

        void UpdateOrder(Order order);

        List<OrderDetail> GetOrderDetails();

        OrderDetail GetOrderDetail(int id);

        void AddOrderDetail(OrderDetail orderDetail);

        void DeleteOrderDetail(OrderDetail orderDetail);

        void UpdateOrderDetail(OrderDetail orderDetail);
    }
}
