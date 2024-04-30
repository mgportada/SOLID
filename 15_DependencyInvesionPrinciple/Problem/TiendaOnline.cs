

using DependencyInvesionPrinciple.ExternalLibraries;

namespace DependencyInvesionPrinciple.Problem
{
    public class TiendaOnline
    {
        private Dictionary<Producto, int> cesta = new Dictionary<Producto, int>();
        private CuentaBancaria _cuentaBancaria = new CuentaBancaria(0);

        public void AgregarProducto(Producto producto, int cantidad)
        {
            if (cesta.ContainsKey(producto))
            {
                cesta[producto] += cantidad;
            }
            else
            {
                cesta.Add(producto, cantidad);
            }
        }

        public double CalcularPrecioTotal()
        {
            double precioTotal = 0;
            foreach (var item in cesta)
            {
                precioTotal += item.Key.Precio * item.Value;
            }
            return precioTotal;
        }

        public void Pagar(Visa visa)
        {
            double precioTotal = CalcularPrecioTotal();
            visa.efectuarPago(precioTotal, _cuentaBancaria);
            Console.WriteLine("Pago realizado con éxito!");
            Console.WriteLine("Gracias por su compra!");
        }


    }
}
