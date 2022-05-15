using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N1");
            Console.WriteLine("");
            /*1. Crear un programa donde solicite al usuario un número, si el mismo es mayor que
             cero emitirá un mensaje que diga “El número es positivo”, en caso contrario emitirá
             un mensaje diciendo el número es cero o negativo.*/

            int num; 
            
            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Write("Es Positivo");
            }
            else 
                {
                    if (num == 0)
                    {
                        Console.Write("Es Igual a 0");
                    }
                    else
                    {
                        Console.Write("Es Negativo");
                    }
                }

            Console.ReadKey();
        }
    }
}
