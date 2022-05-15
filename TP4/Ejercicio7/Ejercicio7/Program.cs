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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N7");
            Console.WriteLine("");
            /*7. Crea un programa que pida al usuario dos números enteros y diga "Uno de los
             * números es positivo", "Los dos números son positivos" o bien "Ninguno de los
             * números es positivo", según corresponda.*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num > 0 && num2 > 0)
            {
                Console.Write("Ambos son Positivos");
            }
            else
            {
                if (num > 0 || num2 > 0)
                {
                    Console.Write("Uno de los Numeros es Positivos");
                }
                else
                {
                    Console.Write("Ninguno de los números es positivo");
                }
            }

            Console.ReadKey();
        }
    }
}
