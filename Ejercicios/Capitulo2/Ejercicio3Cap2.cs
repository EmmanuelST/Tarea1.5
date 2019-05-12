using System;

namespace Ejercicio3Cap2
{
    class Program
    {
        static void Main(string[] args)
        {

            double grados;
            double radianes;

            try
            {
                Console.WriteLine("\nIngrese la cantidad de grados a convertir: ");
                grados = double.Parse(Console.ReadLine());

                radianes = (grados * 3.1416) / 180;

                Console.WriteLine("\n\n" + grados + " grados es igual a " + radianes + " radianes\n");
            }
            catch (Exception e) { Console.WriteLine("\nhubo un error de entrada y salida"); }

           



        }
    }
}
