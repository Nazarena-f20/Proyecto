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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N5");
            Console.WriteLine("");
            /*5. Crea un programa que pida al usuario un número entero y responda si no es múltiplo
             * de 2 ni de 3.*/

            int num;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 1 && num % 3 == 1)
            {
                Console.Write("No es múltiplo de 2 ni de 3.");
            }

            Console.ReadKey();
        }
    }
}
