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
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            //2-Crea un programa que escriba en pantalla los números pares del 26 al 10 usando "do..while".

            int num = 26;

            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Pares: " + num);
                    
                }
                num = num - 1;
            } while (num >= 10);

            
            Console.ReadKey();
        }
    }
    
}
