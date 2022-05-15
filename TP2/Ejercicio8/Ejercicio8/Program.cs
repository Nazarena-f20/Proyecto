using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N8");
            Console.WriteLine("");
            //Escribi un programa que solicita al usuario el ingreso de dos palabras, las cuales se guardaran en dos variables distintas.
            //A continuacion, almacena en una variable la concatenacion de la primera palabra, mas un espacio, mas la segunda
            //palabra. Muestra este resultado en pantalla.

            string pal1;
            string pal2;
            string con;

            Console.Write("Ingrese una palabra: ");
            pal1 = Console.ReadLine();

            Console.Write("Inrgese la segunda Palabra: ");
            pal2 = Console.ReadLine();

            con = pal1 + " " + pal2;

            Console.WriteLine("");
            Console.WriteLine("La Concatenacion de las palabras es: " + con);

            Console.ReadKey();
        }
    }
}
