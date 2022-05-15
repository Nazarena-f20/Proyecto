using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");

            /*Escribi un programa que, dado un numero entero, muestre su valor absoluto.
             * Recuerde que, para los numeros positivos su valor absoluto es igual al numero 
             * (el valor absoluto de 52 es 52) mientras que, para los negativos, su valor 
             * absoluto es el numero multiplicado por -1 (el valor dabsoluto de -52 es 52)*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.Write("Valor Absoluto: " + num);
            }
            else
            {
                num2 = num*-1;
                Console.Write("Valor Absoluto: "+ num2);
            }

            Console.ReadKey();
    }
   }
}