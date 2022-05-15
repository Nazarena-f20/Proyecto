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
            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");
            //4-escribi un programa que solicite al usuario ingresar la cantidad de kilometros recorridos por una motocicleta
            //y la cantidad de litros de combustible que consumio durante ese recorrido. Mostrar el consumo de combusible por km.

            float kilo;
            float com;
            float result;

            Console.Write("Ingrese Los Kilometros: ");
            kilo = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la Cantidad de Combustible: ");
            com = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            result = com / kilo;
            Console.WriteLine("El consumo de combustible por kilometro es: " + result);


            Console.ReadKey();
        }
    }
}
