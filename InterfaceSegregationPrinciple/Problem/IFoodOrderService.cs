

namespace InterfaceSegregationPrinciple.Problem
{
    internal interface IFoodOrderService
    {
        void OrderBurger(int quantity);
        void OrderSteak(int quantity);
        void OrderSalad(int quantity);
    }
}
