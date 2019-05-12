using System;

namespace Ejercicio3Cap3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nIngrese el numero correspondiente al dia de la semana\n" +
                "que desea que se imprima en pantalla: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\nDomingo");
                    break;

                case "2":
                    Console.WriteLine("\nLunes");
                    break;

                case "3":
                    Console.WriteLine("\nMartes");
                    break;

                case "4":
                    Console.WriteLine("\nMiercoles");
                    break;

                case "5":
                    Console.WriteLine("\nJueves");
                    break;

                case "6":
                    Console.WriteLine("\nViernes");
                    break;

                case "7":
                    Console.WriteLine("\nSabado");
                    break;

               default:
                    Console.WriteLine("\n\n no es un opcion valida");
                    break;
            }

        }
    }
}
