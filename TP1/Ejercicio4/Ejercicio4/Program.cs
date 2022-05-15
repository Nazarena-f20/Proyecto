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
            Console.WriteLine("TRABAJO PRACTICO N1");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");
            //Escriba un programa donde se multiplique dos números introducido por el usuario. 
            //El programa deberá contener un comentario al principio, que recuerdecuál es su objetivo.

            int num1;
            int num2;
            int resultado;

            Console.WriteLine("Se mostrara el resultado de la Multilplicacion");
            Console.Write("Ingrese un Numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            resultado = num1 * num2;
            Console.WriteLine("El Reultado es: " + resultado);

            Console.ReadKey();
        }


    }
}
