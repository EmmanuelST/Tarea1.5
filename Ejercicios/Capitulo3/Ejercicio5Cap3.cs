using System;

namespace Ejercicio5Cap3
{
    class Program
    {
        static void Main(string[] args)
        {

            float longitud;
            int lados;
            float apotema;
           


            Console.WriteLine("\n\nQue desea hacer: ");
            Console.WriteLine("\n\n\n1-Calcular el Perimetro de un poligono." +
                "\n2-Calcular el area de un poligono." +
                "\n3-Salir.");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\n\nIngrese la cantidad de lados del Poligono: ");
                    lados = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nIngrese la la longitud de los lados del Poligono:");
                    longitud = float.Parse(Console.ReadLine());

                    Console.WriteLine("\n\nEl perimetro del poligono es: "+
                       perimetro(lados,longitud));
                    break;

                case "2":
                    Console.WriteLine("\n\nIngrese la cantidad de lados del Poligono: ");
                    lados = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nIngrese la la longitud de los lados del Poligono:");
                    longitud = float.Parse(Console.ReadLine());
                    Console.WriteLine("\nIngrese la la longitud del apotema del Poligono:");
                    apotema = float.Parse(Console.ReadLine());

                    Console.WriteLine("\n\nEl area del poligono es: " +
                       area(perimetro(lados, longitud),apotema));
                    break;

                default:
                    Console.WriteLine("\nEsta no es una opcion valida.");
                    break;
            }


           
        }

        public static float perimetro(int lados,float longitud)
        {
            return (lados * longitud);
        }

        public static float area(float perimetro,float apotema)
        {
            return (apotema * perimetro)/2;
        }
    }

}
