

namespace DependencyInvesionPrinciple.ExternalLibraries
{
    public class Paypal
    {
        private CuentaBancaria _cuentaBancaria;
        private string _email;
        public Paypal(CuentaBancaria cuentaBancaria, string email)
        {
            this._email = email;
            _cuentaBancaria = cuentaBancaria;
        }
        public void realizarPago(double amount, CuentaBancaria cuentaBancariaDestino)
        {
            Console.WriteLine($"Haciendo pago con paypal: {amount}$");
            _cuentaBancaria.retirarDinero(amount);
            cuentaBancariaDestino.abonarDinero(amount);
        }
    }
}
