using System;

namespace Ejercicio1cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lados;
            float longitud;

            try
            {

                Console.WriteLine("\nIngrese la cantidad de lados del pologino: ");
                lados = int.Parse(Console.In.ReadLine());

                Console.WriteLine("\nIngrese la longitud de los lados del poligono: ");
                longitud = float.Parse(Console.In.ReadLine());

                Console.WriteLine("\n\nEl perimetro del poligono regular es: "
                    + lados + " * " + longitud + " = " + (longitud * lados));

                Console.ReadKey();
            }
            catch (Exception e) { Console.WriteLine("\n Hubo un problema de entrada (IO)"); }


        }
    }
}
