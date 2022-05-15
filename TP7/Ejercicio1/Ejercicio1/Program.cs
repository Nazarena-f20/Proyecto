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
            //1-Escribir un programa que pida al usuario un numero entero positivo y muestre por pantalla todos los numeross 
            //impares desde 1 hasta ese numero separados por comas.

            int num;

            Console.Write("Ingrese un Numero Entero Positivo: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i = i + 1)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.Write("Numeros Hasta " + num + ".");
            Console.ReadKey();
        }
    }
}
