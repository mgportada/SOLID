
namespace LiskovSubstitutionPrinciple.Problem
{
    public class Pinguino : IPajaro
    {
        public void hacerSonido()
        {
            Console.WriteLine("Pinguino hace sonido!");
        }

        public void andar()
        {
            Console.WriteLine("Pinguino camina!");
        }

        public void volar()
        {
            throw new NotImplementedException("Pinguino no puede volar");
        }

        public void nadar()
        {
            Console.WriteLine("Pinguino nada!");
        }
    }
}
