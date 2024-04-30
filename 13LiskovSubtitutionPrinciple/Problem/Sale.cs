

namespace LiskovSubtitutionPrinciple.Problem
{
    public class Sale : AbstractSale
    {
        public Sale(decimal amount, decimal price, string customer, decimal taxes)
        {
            this.amount = amount;
            this.price = price;
            this.customer = customer;
            this.taxes = taxes;
        }
        public override decimal CalculateTaxes()
        {
            decimal taxesIncrement = amount * price * taxes;
            Console.WriteLine($"Generating sale taxesIncrement = {amount * price * taxesIncrement}");
            return taxesIncrement;
        }

        public override decimal Generate()
        {
            decimal total = amount * price;
            Console.WriteLine($"Generating foreign sale = {amount * price}");
            return total;
        }


    }
}
