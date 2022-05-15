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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N8");
            Console.WriteLine("");
            /*8. Crea un programa que pida al usuario tres números y muestre cuál es el mayor de los tres.*/

            int num, num2, num3;

            Console.Write("Ingrese Un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Un Tercer Numero: ");
            num3 = int.Parse(Console.ReadLine());

            if (num > num2 && num > num3)
            {
                Console.WriteLine("El Primero es el Mayor de los Tres");
            }
            else
            {
                if (num2 > num && num > num3)
                {
                    Console.WriteLine("El Segundo es el Mayor de los Tres");
                }
                else
                {
                    Console.WriteLine("El Tercero es el Mayor de los Tres");
                }
            }

            Console.ReadKey();
        }
    }
}
