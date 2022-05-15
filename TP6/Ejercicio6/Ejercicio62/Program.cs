using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");
            /*6-Observar los término de la siguiente serie: 200, 198, 196, 194,..., tn-1, con tn-1>0 mostrar la suma de la
            serie completa. Hacer uso de la estructura do while.*/


            int tn = 200;
            int suma = 0;

            do
            {
                if (tn % 2==0)
                {
                    Console.WriteLine(tn);
                suma = suma + tn;
                }
                
                tn = tn - 1;

            } while (tn > -2);

            Console.WriteLine("");
            Console.Write("La suma de la serie completa es: " + suma);

            Console.ReadKey();
        }
    }
}
