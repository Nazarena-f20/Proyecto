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
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N4");
            Console.WriteLine("");
            /*4- crea un programa doonde el usuario ingresara por teclado el numero entero que representa la cantidad de lados
             * de una figura geometrica. Cuando se ingrese dicho numero el programa emitira un msj por consola diciendo si es 
             * figura o no, si es triangulo, cuadrado o rectangulo, pentagono, hexagono, octagono o no esta registrada.*/

            int num;

            Console.Write("Ingrese el Numero de Lados: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 3:
                    Console.Write("El numero de lados Indica un TRIANGULO");
                    break;
                case 4:
                    Console.Write("El numero de lados Indica un CUADRADO o RECTANGULO");
                    break;
                case 5:
                    Console.Write("El numero de lados Indica un PENTAGONO");
                    break;
                case 6:
                    Console.Write("El numero de lados Indica un HEXAGONO");
                    break;
                case 8:
                    Console.Write("El numero de lados Indica un OCTAGONO");
                    break;
                default:
                    Console.Write("NO ESTA REGISTRADO");
                    break;
            }
            Console.ReadKey();
        }
    }
}
