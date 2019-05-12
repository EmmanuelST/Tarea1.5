using System;

namespace Ejercicio5cap2
{
    class Program
    {
        static void Main(string[] args)
        {

            float dolares;
            float euros;
            bool ciclo = true;

            do
            {

                Console.WriteLine("Como desea convertir?"
                    + "\n\n1:Dolares a Euros."
                    + "\n2:Euros a Dolares."
                    + "\n3:salir.");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("\nIngrese la cantidad de Dolares a convertir: ");
                        dolares = float.Parse(Console.ReadLine());

                        Console.WriteLine("\n\n" + dolares + " de Dolares es igual a " + (dolares * 0.89) + " Euros");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("\nIngrese la cantidad de Euros a convertir: ");
                        euros = float.Parse(Console.ReadLine());

                        Console.WriteLine("\n\n " + euros + " de Euros es igual a " + (euros * 1.12) + " Dolares");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("\n\n\n hasta luego....\n");
                        ciclo = false;

                        break;

                    default:
                        Console.WriteLine("\nno es un opcion valida");

                        break;
                }
            } while (ciclo == true);





        }
    }
}
