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
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N9");
            Console.WriteLine("");
            //Escribi un prograama que solicite al usuario que ingrese cuantos shows musicales ha visto en el ultimo año
            //y almacene ese numero en una variable. Acontinuacion, mostrar en pantalla un valor de verdad (True o False)
            //que indique si el uduario ha visto mas de 3 shows.

            int sh;

            Console.Write("Ingrese cuantos shows a visto en el ultimo año: ");
            sh = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("¿Vio mas de 3 shows?:");
            if (sh > 3)
                Console.Write(" True");
            else
                Console.Write(" False");

            Console.ReadKey();
        }

    }
}
