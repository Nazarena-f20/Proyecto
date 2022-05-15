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
            Console.WriteLine("Ejercicio N3");
            Console.WriteLine("");
            /*Escribi un programa que solicite al usuario dos numeros y los almacene en dos variables. 
             En otra variable, almacena el resultado de la suma de esos dos numeros y luego mestre el rsultado en pantalla.
             A continuacion, el programa debe solicitar al usuario que ingrese un tercer numero, el cual se debe almacenar en una nueva variable.
             Por ultimo, muestra en pantalla el resultado de la multiplicacion de este nuevo numero por el resultado de la suma anterior.*/

            int num;
            int num1;
            int num3;
            float resultado;
            float resultado1;

            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un segundo numero: ");
            num1 = int.Parse(Console.ReadLine());

            resultado = num + num1;
            Console.Write("La suma es: " + resultado);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Ingrese un tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            resultado1 = num3 * resultado;
            Console.Write("El producto del nuevo numero y de la suma anterior es: " + resultado1);

            Console.ReadKey();
        }
    }
}
