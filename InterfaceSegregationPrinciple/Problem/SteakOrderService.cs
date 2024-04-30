
namespace InterfaceSegregationPrinciple.Problem
{
    internal class SteakOrderService : IFoodOrderService
    {

        public void OrderBurger(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            Console.WriteLine($"Steak ordered. Quantity: {quantity}");

        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }
    }

}
