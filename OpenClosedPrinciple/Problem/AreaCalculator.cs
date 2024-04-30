namespace OpenClosedPrinciple.Problem
{
    class AreaCalculator
    {
        public static double calcularAreas(Shape[] shapes)
        {
            double area = 0;
            for (int i = 0; i < shapes.Length; i++)
            {
                if (shapes[i] is Rectangulo)
                {
                    area += shapes[i].width * shapes[i].height;
                }
                else if (shapes[i] is Triangulo)
                {
                    area += shapes[i].width * shapes[i].height / 2;
                }
            }
            return area;
        }
    }
}
