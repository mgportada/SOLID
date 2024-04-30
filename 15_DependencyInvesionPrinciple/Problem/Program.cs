using DependencyInvesionPrinciple.ExternalLibraries;

namespace DependencyInvesionPrinciple.Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaManuel = new CuentaBancaria(1000);
            Visa visaManuel = new Visa(cuentaManuel, "123456789");


            TiendaOnline tienda = new TiendaOnline();
            tienda.AgregarProducto(new Producto("Laptop", 1000), 1);
            tienda.AgregarProducto(new Producto("Mouse", 20), 2);

            double precioTotal = tienda.CalcularPrecioTotal();
            Console.WriteLine($"Precio total: {precioTotal}$");
            Console.WriteLine("¿Cómo quieres pagar? (Bizzum/Visa)");
            string metodoPago = Console.ReadLine();
            if (metodoPago == "Visa")
            {
                tienda.Pagar(visaManuel);
            }
            else
            {
                Console.WriteLine("Método de pago no soportado");
            }

        }


    }

}