using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TRABAJO PRACTICO N2");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N5");
            Console.WriteLine("");
            //Escribi un programa que solicite al usuario el ingreso de una temperatura a escala Fahrenheit (debe permitir decimales)
            //y le muestre el equivalente en grados Celsius. La formula de conversion que se usa para este calculo
            //es: celsius = (5/7) * (Fahrenheit - 32)


            float fah;
            float cel;


            Console.Write("Ingrese una Temperatura en Escala Fahrenheit: ");
            fah = float.Parse(Console.ReadLine());

            cel = (fah-32) * 5/9 ;
            
            Console.WriteLine("");
            Console.WriteLine("La temperatura Ingresada en Celsius es: " + cel + "Cº");


            Console.ReadKey();
        }
    }
}
