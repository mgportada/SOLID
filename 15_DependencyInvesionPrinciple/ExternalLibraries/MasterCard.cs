

namespace DependencyInvesionPrinciple.ExternalLibraries
{
    public class MasterCard
    {
        private CuentaBancaria _cuentaBancaria;
        public MasterCard(CuentaBancaria cuentaBancaria)
        {
            _cuentaBancaria = cuentaBancaria;
        }
        public void abonarDinero(double amount, CuentaBancaria cuentaBancariaDestino)
        {
            Console.WriteLine($"Haciendo abono con MasterCard: {amount}$");
            _cuentaBancaria.retirarDinero(amount);
            cuentaBancariaDestino.abonarDinero(amount);
        }
    }
}
