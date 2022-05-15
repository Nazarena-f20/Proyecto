using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");

            /*Escribi un programa para solicitar al usuario tres numeros y mostrar
             * en pantalla al menor de los tres*/

            int num1, num2, num3;

            Console.Write("Ingrese un Numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un Tercer Numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (num1 < num2 && num1 < num3)
            {
                Console.Write("El Primero es el Menor de los tres");
            }
            else
            {
                if (num2 < num1 && num2 < num3)
                {
                    Console.Write("El Segundo es el Menor de los tres");
                }
                else
                {
                    if (num3 < num1 && num3 < num2)
                    {
                        Console.Write("El Tercero es el Menor de los tres");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
