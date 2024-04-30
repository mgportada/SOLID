

namespace InterfaceSegregationPrinciple.Problem
{
    internal class SaladOrderService : IFoodOrderService
    {

        public void OrderBurger(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSalad(int quantity)
        {
            Console.WriteLine($"Salad ordered. Quantity: {quantity}");
        }
    }

}
