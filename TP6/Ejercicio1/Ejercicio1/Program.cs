using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N1");
            Console.WriteLine("");
            /*1-Mostrar la suma y los números impares que hay entre 100 al 200*/

            int num = 100;
            int suma = 0;

            while (num < 200)
            {
                
                if (num % 2 != 0)
                {
                    suma = suma + num;
                    Console.WriteLine("impares: " + num);
                     
                }
                num = num + 1;
            }
            Console.Write("La suma es: " + suma);

            Console.ReadKey();
            
        }
    }
}
