

namespace OpenClosedPrinciple.Problem
{
    public class Program
    {
        public static void Main2(string[] args)
        {
            Shape rectangulo = new Rectangulo(10, 5);
            Shape triangulo = new Triangulo(10, 5);

            double totalArea = AreaCalculator.calcularAreas(new Shape[] { rectangulo, triangulo });
            Console.WriteLine(totalArea);
        }
    }
}