

namespace DependencyInversionPrinciple.Problem
{
    public class OrderService
    {
        public readonly DataDogService _datadogService;

        public OrderService()
        {
            _datadogService = new DataDogService();
        }

        public void GenerateOrder(Order order)
        {
            // Generate order
            _datadogService.Log($"Order generated for {order.ProductName}, quantity = {order.Quantity}");
        }



    }
}
