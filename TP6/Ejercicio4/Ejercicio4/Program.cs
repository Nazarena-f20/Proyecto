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
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");
            //4-Crear un programa que muestre los números del 15 al 50, de forma descendente.

            int num = 50;
            Console.WriteLine("Descentente: ");
            do
            {
                Console.WriteLine(num);
                num = num - 1;
            } while (num >= 15);

            Console.ReadKey();
        }
    }
}
