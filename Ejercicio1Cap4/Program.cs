using System;

namespace Ejercicio1Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\ningrese el numero del que desea mostrala su tabla del 1 al 10: ");
            int numero;
            numero = int.Parse(Console.ReadLine());


            for(int i=1;i<11;i++)
            {
                Console.WriteLine("\n"+numero+" * "+i+" = "+(numero*i));
            }
        }
    }
}
