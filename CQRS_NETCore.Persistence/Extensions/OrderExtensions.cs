using CQRS_NETCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_NETCore.Persistence.Extensions
{
    internal static class OrderExtensions
    {
        public static Order AddOrderDetails(this Order order, params OrderDetail[] orderDetails)
        {
            foreach (var orderDetail in orderDetails)
            {
                order.OrderDetails.Add(orderDetail);
            }

            return order;
        }
    }
}
