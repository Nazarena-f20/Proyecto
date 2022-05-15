using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");
            /* 6- Modifique el ejercicio anterior pero para los dias*/

            int num;

            Console.Write("Ingrese un Numero del 1 al 7: ");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.Write("Dia: DOMINGO");
                    break;
                case 2:
                    Console.Write("Dia: LUNES");
                    break;
                case 3:
                    Console.Write("Dia: MARTES");
                    break;
                case 4:
                    Console.Write("Dia: MIERCOLES");
                    break;
                case 5:
                    Console.Write("Dia: JUEVES");
                    break;
                case 6:
                    Console.Write("Dia: VIERNES");
                    break;
                case 7:
                    Console.Write("Dia: SABADO");
                    break;
            }

            Console.ReadKey();
        }
    }
}
