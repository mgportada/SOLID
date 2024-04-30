namespace LiskovSubstitutionPrinciple.Problem
{
    public class Pato : IPajaro
    {
        public void hacerSonido()
        {
            Console.WriteLine("Quack Quack!");
        }

        public void volar()
        {
            Console.WriteLine("Pato Volando!");
        }

        public void nadar()
        {
            Console.WriteLine("Pato nadando!");
        }


        public void andar()
        {
            Console.WriteLine("Pato andando");
        }
    }
}
