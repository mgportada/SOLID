namespace LiskovSubstitutionPrinciple.Problem
{
    public class PatoPlastico : IPajaro
    {
        public void volar()
        {
            throw new NotImplementedException("Pato de plástico no puede volar");
        }

        public void nadar()
        {
            Console.WriteLine("Pato de plástico nadando en la bañera!");
        }

        public void hacerSonido()
        {
            Console.WriteLine("Quack!!!");
        }

        public void andar()
        {
            throw new NotImplementedException("Pato de plástico no puedo andar");
        }
    }
}
