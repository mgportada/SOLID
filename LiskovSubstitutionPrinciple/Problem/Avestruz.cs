namespace LiskovSubstitutionPrinciple.Problem
{
    public class Avestruz : IPajaro
    {
        public void volar()
        {
            throw new NotImplementedException("Avestruz no puede volar");
        }

        public void nadar()
        {
            throw new NotImplementedException("Avestruz no puede nadar");
        }

        public void hacerSonido()
        {
            Console.WriteLine("Gruñido Avestruz");
        }

        public void andar()
        {
            Console.WriteLine("Avestruz corriendo a 70km/h!");
        }
    }
}
