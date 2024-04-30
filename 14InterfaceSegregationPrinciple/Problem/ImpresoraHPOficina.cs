
namespace InterfaceSegregationPrinciple.Problem
{
    internal class ImpresoraHPOficina : IImpresoraHP
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
            Console.WriteLine("Faxenado: " + contenido);
        }
    }
}
