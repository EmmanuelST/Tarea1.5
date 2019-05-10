using System;

namespace Ejercicio4Cap2
{
    class Program
    {
        static void Main(string[] args)
        {
            float c,f;

            Console.WriteLine("\n\nIngrese la cantidad de grados Centigrados que desea convertir a fahrenheit: ");

            c = float.Parse( Console.ReadLine());
            f= ((c * 9) / 9) + 32;
            Console.WriteLine("\n\n"+c+" grados Centigrados es igual a "+f+ " grados fahrenheit");
        }
    }
}
