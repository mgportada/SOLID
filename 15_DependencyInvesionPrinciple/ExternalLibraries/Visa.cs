

namespace DependencyInvesionPrinciple.ExternalLibraries
{
    public class Visa
    {
        private CuentaBancaria _cuentaBancaria;
        private string _numeroTarjeta;
        public Visa(CuentaBancaria cuentaBancaria, string numeroTarjeta)
        {
            _cuentaBancaria = cuentaBancaria;
            _numeroTarjeta = numeroTarjeta;
        }

        public void efectuarPago(double amount, CuentaBancaria cuentaBancariaDestino)
        {
            Console.WriteLine($"Haciendo pago con paypal: {amount}$");
            _cuentaBancaria.retirarDinero(amount);
            cuentaBancariaDestino.abonarDinero(amount);
        }
    }
}
