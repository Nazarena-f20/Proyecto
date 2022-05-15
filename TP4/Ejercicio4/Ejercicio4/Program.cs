using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");
            /*4. Crea un programa que pida al usuario un número entero y responda si es múltiplo de
               2 o de 3.*/

            int num;

            Console.Write("Ingrese un Numer: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.Write("Es multiplo de 2");
            }
            else
            {
                if (num % 3 == 0)
                {
                    Console.Write("Es multiplo de 3");
                }
            }

            Console.ReadKey();
        }
    }
}
