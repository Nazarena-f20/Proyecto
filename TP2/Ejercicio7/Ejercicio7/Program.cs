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
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N7");
            Console.WriteLine("");
            //Escribi un programa que solicite al usuario un numero y le reste el 15%, almacenando todo en una unica variable.
            //a continuacion, mostrar el resultado final en pantalla.

            float num1;
            float por;

            Console.Write("Ingrese un Numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            por = (num1 / 100)*15;

            Console.WriteLine("El porcentaje de " + num1 + " es: " + por);


            Console.ReadKey();
        }
    }
}
