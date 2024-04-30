

namespace InterfaceSegregationPrinciple.Problem
{
    internal class BurgerOrderService : IFoodOrderService
    {

        public void OrderBurger(int quantity)
        {
            Console.WriteLine($"Burger ordered. Quantity: {quantity}");
        }

        public void OrderSteak(int quantity)
        {
            throw new NotImplementedException();
        }

        public void OrderSalad(int quantity)
        {
            throw new NotImplementedException();
        }
    }

}
