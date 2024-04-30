using System;

namespace LiskovSubstitutionPrinciple.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Pato pato = new Pato();
            Avestruz avestruz = new Avestruz();
            PatoPlastico patoGoma = new PatoPlastico();
            Pinguino pinguino = new Pinguino();

            var pajaros = new IPajaro[] { pato, avestruz, patoGoma };

            MostrarSonidos(pajaros);
            AndarEnLago(pajaros);
            NadarEnLago(pajaros);
            VolarEnLago(pajaros);
        }

        static void MostrarSonidos(IPajaro[] pajaros)
        {
            Console.WriteLine("¿Estáis todos?");
            foreach (var pajaro in pajaros)
            {
                pajaro.hacerSonido();
            }
        }

        static void AndarEnLago(IPajaro[] pajaros)
        {
            Console.WriteLine("¡Id al lago!");
            foreach (var pajaro in pajaros)
            {
                pajaro.andar();
            }
        }

        static void NadarEnLago(IPajaro[] pajaros)
        {
            Console.WriteLine("¡A nadar!");
            foreach (var pajaro in pajaros)
            {
                pajaro.nadar();
            }
        }

        static void VolarEnLago(IPajaro[] pajaros)
        {
            Console.WriteLine("¡A volar!");
            foreach (var pajaro in pajaros)
            {
                pajaro.volar();
            }
        }
    }
}
