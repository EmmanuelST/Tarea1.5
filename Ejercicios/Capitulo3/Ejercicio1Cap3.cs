using System;

namespace Ejercicio1Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;

            Console.WriteLine("\n\nIngrese el numero que desea verificar: ");

            try
            {
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception e) { Console.WriteLine("Hubo un erro a introducir datos"); }

            if(numero % 2 == 0)
                Console.WriteLine("\n\nEl numero ingresado es par");
            else
                Console.WriteLine("\n\nEl numero ingresado no es par");

            Console.ReadKey();

        }
    }
}
