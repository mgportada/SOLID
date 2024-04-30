
namespace InterfaceSegregationPrinciple.Problem
{
    internal class ImpresoraHPModel2 : IImpresoraHP
    {
        public void Imprimir(string contenido)
        {
            Console.WriteLine("Imprimiendo: " + contenido);
        }

        public void Escanear(string contenido)
        {
            Console.WriteLine("Escaneando: " + contenido);
        }

        public void Faxear(string contenido)
        {
            throw new NotImplementedException();
        }
    }
}
