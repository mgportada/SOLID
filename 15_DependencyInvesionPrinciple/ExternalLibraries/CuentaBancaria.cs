

namespace DependencyInvesionPrinciple.ExternalLibraries
{
    public class CuentaBancaria
    {
        private double saldo;

        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void abonarDinero(double amount)
        {
            saldo += amount;
        }

        public void retirarDinero(double amount)
        {
            saldo -= amount;
        }
    }
}
