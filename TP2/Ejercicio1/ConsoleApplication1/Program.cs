using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N1");
            Console.WriteLine("");
        /*Escribi el programa que solicite al usuario que ingrese su nombre. El nombre debe se debe almacenar en una variable llamada nombre. 
         * A continuacion, se debe mostrar en pantalla el texto "Ahora estas en el matrix, [usuario]", donde "[usuario]"
         * se reemplazara por el nombre que el usuario haya ingresado.*/

            string nombre;
       
            Console.Write("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Ahora estas en la Matrix, " + nombre);
            


            Console.ReadKey();
        }
    }
}
