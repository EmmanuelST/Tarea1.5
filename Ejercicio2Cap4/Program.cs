using System;

namespace Ejercicio2Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nIngrese el numero al que desea elevar: ");
            int numero = int.Parse(Console.ReadLine());
            int aux = numero;

            if (numero < 1)
            {
                Console.WriteLine("\nnumero no valido");

            }else
            {
                Console.WriteLine("\n\ningrese la potencia a la que desea elevarlo: ");
                int potencia = int.Parse(Console.ReadLine());
                if (potencia > -1)
                {
                    if (potencia == 0)
                    {
                        numero = 1;

                    }
                    else
                if (potencia == 1)
                    {
                        numero = aux;

                    }
                    else
                        for (int i = 0; i < potencia - 1; i++)
                        {

                            numero *= numero;
                        }

                    Console.WriteLine("\n\nLa potencia de " + aux + " elevado a la potencia de "+potencia+ " es:" + numero);
                }
                else
                    Console.WriteLine("\nnumero no valido");
                
            }
            
        }
    }
}
