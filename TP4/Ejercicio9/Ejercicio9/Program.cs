using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N9");
            Console.WriteLine("");
            /*9. Crea un programa que pida al usuario dos números enteros y diga si son iguales o, en
             * caso contrario, cuál es el mayor de ellos.*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num == num2)
            {
                Console.Write("Son Iguales");
            }
            else
            {
                if (num > num2)
                {
                    Console.Write("El Primero es Mayor");
                }
                else
                {
                    Console.Write("El Segundo es Mayor");
                }
            }

          Console.ReadKey();
        }
    }
}
