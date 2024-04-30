namespace LiskovSubtitutionPrinciple.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(10, 20, "John", 0.1m);


            ForeignSale foreignSale = new ForeignSale(10, 20, "John");

            decimal total = GenerateTotal(sale);
            decimal totalForeign = GenerateTotal(foreignSale);

        }

        static decimal GenerateTotal(AbstractSale sale)
        {
            decimal finalPrice = sale.CalculateTaxes() + sale.CalculateTaxes();
            Console.WriteLine($"FinalPrice = {finalPrice}");
            return finalPrice;
        }
    }
}