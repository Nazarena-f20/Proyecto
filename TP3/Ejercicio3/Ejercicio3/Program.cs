using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N3");
            Console.WriteLine("");
            /*3-Escribi un programa que solicite al usuario su edad y la guarde en una variable.
             * Que luego solicite la cantidad de articulos comprados en una tienda y la guarde 
             * en otra variable.Finalmente, mostrar en pantalla un valor de verdad (T o F) que indique
             * si el usuario es mayor de 18 años de edad y ademas compro mas de 1 articulo*/

            int edad, articulo;

            Console.Write("Ingrese su Edad: ");
            edad = int.Parse(Console.ReadLine());
                 
            Console.Write("Ingrese la Cantidad de Articulos Comprados: ");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (edad > 18 && articulo > 1)
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
