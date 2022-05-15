using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N5");
            Console.WriteLine("");
            //5-Crear un programa que muestre los primeros ocho números pares. Partiendo de cero.

            int num = 0;
            int pares = 1;

            Console.WriteLine("Pares: ");
            while (num <= 14)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(pares + "-" + num);
                    pares = pares + 1;
                }
                num = num + 1;
            }

            Console.ReadKey();
        }
    }
}
