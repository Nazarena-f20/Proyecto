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
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N5");
            Console.WriteLine("");
            /* 5-Crear un programa donde se ingrese un numero del 1 al 12 que representa un mes del año
             * y mostrar por consola el mes pero en palabras y a que estacion pertenece dicho mes.*/

            int num;

            Console.Write("Ingrese un Numero del 1 al 12: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.Write("Mes: ENERO, Estacion: VERANO");
                    break;
                case 2:
                    Console.Write("Mes: FEBRERO, Estacion: VERANO");
                    break;
                case 3:
                    Console.Write("Mes: MARZO, Estacion: VERANO-OTOÑO");
                    break;
                case 4:
                    Console.Write("Mes: ABRIL, Estacion: OTOÑO");
                    break;
                case 5:
                    Console.Write("Mes: MAYO, Estacion: OTOÑO");
                    break;
                case 6:
                    Console.Write("Mes: JUNIO, Estacion: OTOÑO-INVIERNO");
                    break;
                case 7:
                    Console.Write("Mes: JULIO, Estacion: INVIERNO");
                    break;
                case 8:
                    Console.Write("Mes: AGOSTO, Estacion: INVIERNO");
                    break;
                case 9:
                    Console.Write("Mes: SEPTIEMBRE, Estacion: INVIERNO-PRIMAVERA");
                    break;
                case 10:
                    Console.Write("Mes: OCTUBRE, Estacion: PRIMAVERA");
                    break;
                case 11:
                    Console.Write("Mes: NOVIEMRE, Estacion: PRIMAVERA");
                    break;
                case 12:
                    Console.Write("Mes: DICIEMBRE, Estacion: PRIMAVERA-VERANO");
                    break;
            }

            Console.ReadKey();
        }
    }
}
