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
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N5");
            Console.WriteLine("");
            /*Escribi un Programa que solicite al usuario el ingreso de 2 numeros 
             * diferentes y muestre en pantalla al mayor de dos*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Ingrese otro Numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (num > num2)
            {
                Console.Write(" " + num + " es Mayor");
            }
            else 
            {
                Console.Write(" " + num2 + " es Mayor");
            }

            Console.ReadKey();

        }
    }
}
