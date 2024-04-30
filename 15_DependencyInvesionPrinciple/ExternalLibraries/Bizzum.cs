

namespace DependencyInvesionPrinciple.ExternalLibraries
{
    public class Bizzum
    {
        private CuentaBancaria _cuentaBancaria;
        private string _telefono;
        public Bizzum(CuentaBancaria cuentaBancaria, string telefono)
        {
            this._telefono = telefono;
            _cuentaBancaria = cuentaBancaria;
        }

        public void enviarDinero(double amount, CuentaBancaria cuentaBancariaDestino)
        {
            Console.WriteLine($"Enviando dinero con Bizzum: {amount}$");
            _cuentaBancaria.retirarDinero(amount);
            cuentaBancariaDestino.abonarDinero(amount);
        }
    }
}
