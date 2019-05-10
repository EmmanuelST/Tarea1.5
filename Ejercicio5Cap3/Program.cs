using System;

namespace Ejercicio5Cap3
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;
            float longitud;
            int lados;


            try
            {

                Console.WriteLine("\n\nIngrese el nombre del poligono regular al \n" +
                    "cual le desea calcular el perimetro: ");

                nombre = Console.ReadLine();

                Console.WriteLine("\n\nIngrese la cantidad de lados que tiene el " + nombre + " :");
                lados = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\nIngrese la longitud de los lados del " + nombre + " :");
                longitud = float.Parse(Console.ReadLine());

                Console.WriteLine("\n\n\nEl perimetro del " + nombre + " es: " + (lados * longitud));
            }
            catch (Exception e) { Console.WriteLine("\n\nHubo un erro en el formato de entradad de los datos."); }

           
        }
    }
}
