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
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N1");
            Console.WriteLine("");
            //1-Crea un programa que pida un numero del 1 al 5 al usuario, y escriba el nombre de ese numero, usando 
            //"switch" (por ejemplo, si introduce "1", el programa escribira "uno".

            int num;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());


            switch (num)
            {
                case 1:
                    Console.Write("El Numero es: 'UNO'");
                    break;
                case 2:
                    Console.Write("El Numero es: 'DOS'");
                    break;
                case 3:
                    Console.Write("El Numero es: 'TRES'");
                    break;
                case 4:
                    Console.Write("El Numero es: 'CUATRO'");
                    break;
                case 5:
                    Console.Write("El Numero es: 'CINCO'");
                    break;
            }
            Console.ReadKey();
        }
    }
}
