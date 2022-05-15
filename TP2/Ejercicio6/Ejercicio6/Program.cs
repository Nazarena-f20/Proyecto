using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");
            //Escribi un programa que solicite al usuario ingresar tres numeros para luego mostrar el promedio de los tres.

            float num1;
            float num2;
            float num3;
            float prom;
            float sum;

            Console.Write("Ingrese un numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un Segundo numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese un tercer numero: ");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            sum = num1 + num2 + num3;
            prom = sum / 3;

            Console.WriteLine("El Promeio de los numeros Ingresados es: " + prom);

            Console.ReadKey();
        }
    }
}
