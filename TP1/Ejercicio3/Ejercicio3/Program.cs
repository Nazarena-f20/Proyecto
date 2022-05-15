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
            Console.WriteLine("TRABAJO PRACTICO N1");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            //Crear un programa donde el usuario introduzca tres números y mostrar la suma, resta división y multiplicación.


            int num1;
            int num2;
            int num3;
            int resultado;

            Console.Write("Ingrese un Numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un Segundo Numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un Tercer Numero: ");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            resultado = num1 + num2 + num3;
            Console.WriteLine("La suma de los numeros es: " + resultado);

            resultado = num1 - num2 - num3;
            Console.WriteLine("La resta de los numeros es: " + resultado);

            resultado = num1 * num2 * num3;
            Console.WriteLine("La multiplicacion de los numeros es: " + resultado);

            resultado = num1 / num2 / num3;
            Console.WriteLine("La division de los numeros es: " + resultado);

            Console.ReadKey();

        }
    }
}
