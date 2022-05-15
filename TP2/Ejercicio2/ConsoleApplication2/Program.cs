using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            /*Escribi un programa que solicite al usuario ingresar un numero con decimales y almacenalos en una variable. 
            A continuacion, el programa debe solicitar al usuario que ingrese un numero entero y guardalo en otra variable.
            en una tercera variable se debera guardar el resultado de la suma de los dos numeros ingresados por el usuario.
            por ultimo debe mostrar en pantalla el texto "El resultado de la suma es[suma]", 
            donde [suma] se reemplazara por el resultado de la operacion*/
         

            int num = 0;
            float num1 = 0;
            float resultado;

            Console.Write("Ingrese un Numero Decimale: ");
            num1 = float.Parse( Console.ReadLine());

            Console.Write("Ingrese un Numero Entero: ");
            num = int.Parse( Console.ReadLine());

            Console.WriteLine("");
            resultado = num + num1;
            Console.Write("El Resultado de la Suma: "+ resultado);


            Console.ReadKey();
        }
    }
}
