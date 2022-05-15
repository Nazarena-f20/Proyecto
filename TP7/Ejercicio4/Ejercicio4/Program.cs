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
            //4-Escribir un programa que muestre el eco de todo lo que el usuario introduzca hasta que el usuario
            //escriba "salir" que terminara. Por ejemplo el usuario introduce la palabra "hola" y debera escribir 7 veces "hola"
            //o cualquier palabra se repartira 7 veces.

            char palabra;
            char sa = "salir";

            Console.Write("Introduzca una Palabra: ");
            palabra = char.Parse(Console.ReadLine());

            if (palabra != "salir")
            {
                 for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine(palabra);
                   
                 } 
                Console.Write("Introduzca una Palabra: ");
                palabra = Console.ReadLine();
            }
                Console.Write("Finalizado");
            Console.ReadKey();
        }
    }
}
