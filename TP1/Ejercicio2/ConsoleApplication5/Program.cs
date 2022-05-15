using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N1");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            //Crear un programa donde se muestre la suma, resta división y multiplicación entre los números 313 y 301.

            int num1 = 313;
            int num2 = 301; 
            int suma;
            int resta;
            float div;
            int mul;

            Console.WriteLine("Los numeros son: 313 y 301");
            Console.WriteLine("");
            suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);
            resta = num1 - num2;
            Console.WriteLine("La resta es: " + resta);
            div = num1 / num2;
            Console.WriteLine("La division es: " + div);
            mul = num1 * num2;
            Console.WriteLine("La multiplicacion es: " + mul);

            Console.ReadKey();
        }
    }
}
