
namespace InterfaceSegregationPrinciple.Problem
{
    public class Program
    {
        public static void Main2(string[] args)
        {
            BurgerOrderService burgerOrderService = new BurgerOrderService();
            burgerOrderService.OrderBurger(2);

            SaladOrderService saladOrderService = new SaladOrderService();
            saladOrderService.OrderSalad(1);

            SteakOrderService steakOrderService = new SteakOrderService();
            steakOrderService.OrderSteak(4);
        }
    }
}