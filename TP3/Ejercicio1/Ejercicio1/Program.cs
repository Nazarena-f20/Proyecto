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
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N1");
            Console.WriteLine("");
            /*1-Escribi un programa que le solicite al usuario ingresar una fecha formada por 8 numeros,
            * donde los primeros dos representan el dia, los siguientes dos el ,es y los ultimos cuatro
            * el año (DDMMAAA). Este dato debe guardarse en una variable con tipo int (numero entero).
            * Finalmente, mostrar al usuario la fecha con el formato DD/MM/AAAA.*/

            int fecha, dia, mes, año;
           
            Console.Write("Ingrese una fecha: ");
            fecha = int.Parse(Console.ReadLine());

            dia = fecha / 1000000;
            mes = fecha % 1000000;
            mes = mes / 10000;
            año = fecha / 1000;
            año = fecha % 10000;

            Console.Write("Fecha: " + dia + "/" + mes + "/" + año);

            Console.ReadKey();
        }
    }
}
