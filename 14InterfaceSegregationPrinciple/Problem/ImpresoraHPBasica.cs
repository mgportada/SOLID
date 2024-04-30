namespace InterfaceSegregationPrinciple.Problem
{
    public class ImpresoraHPBasica : IImpresoraHP
    {
        public void Imprimir(string contenido)
        {
            Console.WriteLine("Imprimiendo: " + contenido);
        }

        public void Escanear(string contenido)
        {
            throw new NotImplementedException();
        }

        public void Faxear(string contenido)
        {
            throw new NotImplementedException();
        }
    }
}
