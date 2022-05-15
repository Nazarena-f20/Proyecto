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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");
            /*6. Crea un programa que pida al usuario dos números enteros y diga si ambos son pares.*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num2 % 2 == 0)
            {
                Console.Write("Ambos Numeros son pares");
            }

            Console.ReadKey();
        }
    }
}
