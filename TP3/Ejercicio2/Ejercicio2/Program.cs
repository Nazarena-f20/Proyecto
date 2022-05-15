using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            /*Escribi un programa para solicitar al usuario el ingreso de un numero entero
             * y que luego imprima un valor de verdad dependiendo si el numero es par o no.
             * Recordar que un numero par si el resto, al dividirlo por 2, es 0.*/

            int num;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
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
