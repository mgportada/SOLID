
namespace InterfaceSegregationPrinciple.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            ImpresoraHPOficina impresoraPepe = new ImpresoraHPOficina();
            ImpresoraHPBasica impresoraMaria = new ImpresoraHPBasica();
            ImpresoraHPModel2 impresoraJuan = new ImpresoraHPModel2();


            string contenido = "Vacaciones para todos los trabajadores!";

            IImpresoraHP[] impresoraEmpleados = new IImpresoraHP[] { impresoraPepe, impresoraMaria, impresoraJuan };
            faxMulticast(impresoraEmpleados, contenido);
        }
        static void faxMulticast(IImpresoraHP[] impresoras, string contenido)
        {
            foreach (var impresora in impresoras)
            {
                impresora.Faxear(contenido);
            }
        }
    }
}