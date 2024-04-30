using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Problem
{
    public class Program
    {
        static void Main2(string[] args)
        {
            OrderService orderService = new OrderService();
            Order order = new Order
            {
                OrderId = 1,
                ProductName = "Laptop",
                Quantity = 1,
                TotalAmount = 1000,
                OrderDate = DateTime.Now
            };
            orderService.GenerateOrder(order);
        }
    }
}
