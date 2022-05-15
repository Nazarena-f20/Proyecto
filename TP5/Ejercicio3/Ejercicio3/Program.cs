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
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N3");
            Console.WriteLine("");
            //3-Crea un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numerica
            //o una consonante, usando switch.

            char let;

            Console.Write("Presione una tecla: ");
            let = char.Parse(Console.ReadLine());

            switch (let)
            {
                case 'a': case 'e': case 'i': case 'o': case 'u':
                    Console.Write("La letra tecleada se trata de una Vocal");
                    break;

                case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
                    Console.Write("La letra tecleada se trata de una Cifra Numérica");
                    break;

                default: 
                    Console.Write("La letra tecleada se trata de una Consonante");
                    break;
            }

            Console.ReadKey();
        }
    }
}
