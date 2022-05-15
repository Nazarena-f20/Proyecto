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
            Console.WriteLine("TRABAJO PRACTICO N1");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            //5. Escribir un programa donde se introduzca un número y deberá mostrar el número ingresado, 
            //el posterior y el anterior a dicho número.

            int num;
            int numA;
            int numP;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            numA = num - 1;
            numP = num + 1;

            Console.WriteLine("");
            Console.WriteLine("El numero Ingresado es: " + num);
            Console.Write("Su posterior es: " + numP);
            Console.Write(" Y su anterior es: " + numA);



            Console.ReadKey();
        }
    }
}
