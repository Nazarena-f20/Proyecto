using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N7");
            Console.WriteLine("");
            //Escribir el programa en C#, a partir del siguiente diagrama de flujo.

            int n, suma;
            int a = 0, b = 1;

            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("a=" + a + " b=" + b);

            do
            {
                suma = a + b;
                Console.WriteLine(suma);
                a = b;
                b = suma;
            } while (suma<n);

            Console.ReadKey();

        }
    }
}
