using System;

namespace Ejercicio5Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            int edad;
            int cont=0;
            int acumulador=0;
            int mayor=0;
            int menor=10000000;

            Console.WriteLine("\n\nIngrese la cantidad de persona: ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\n\nIngrese la edad del sujeto #" + i + 1 + " :");
                edad = int.Parse(Console.ReadLine());
                acumulador += edad;

                if (edad > mayor)
                    mayor = edad;
                if (edad < menor)
                    menor = edad;
            }


            Console.WriteLine("\n\nEl promedio de edades es: "+(acumulador / cantidad));
            Console.WriteLine("\n\n La mayor de las edades es: "+mayor+" \n" +
                "y la menor de las edades es: "+menor);
        }
    }
}
