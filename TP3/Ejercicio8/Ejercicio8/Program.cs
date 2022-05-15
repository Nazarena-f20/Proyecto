using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N8");
            Console.WriteLine("");
            /*Escribi un programa que permita saber si un año es bisiesto. Para que un año sea 
             * bisiesto debe ser divisible por 4 y no debe ser divisible por 100, excepto que tambien
             * sea divisible por 400*/

            int año;

            Console.Write("Ingrese el Año: ");
            año = int.Parse(Console.ReadLine());

            if (año % 4 == 0)
            {
                Console.Write("True");
            }
            else
            {
                Console.Write("False");
            }
            Console.ReadKey();
        }
    }
}
