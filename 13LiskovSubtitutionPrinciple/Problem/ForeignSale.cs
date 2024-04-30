using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubtitutionPrinciple.Problem
{
    public class ForeignSale : AbstractSale
    {
        public ForeignSale(decimal amount, decimal price, string customer)
        {
            this.amount = amount;
            this.price = price;
            this.customer = customer;
        }

        public override decimal CalculateTaxes()
        {
            throw new NotImplementedException("No se paga impuestos locales si la venta es en extranjero");
        }

        public override decimal Generate()
        {
            decimal total = amount * price;
            Console.WriteLine($"Generating foreign sale = {amount * price}");
            return total;
        }
    }
}
