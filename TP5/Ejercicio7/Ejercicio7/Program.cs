using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N7");
            Console.WriteLine("");
            /*7-Crear un programa donde simule que tiene disponible 6 habitaciones las cuales se identifican con un numero
             * (los que usted elija). Cuando el usuario ingrese un numero de habitacion debera mostrar dactos ficticios de
             * la habitacion por ejemplo cuantas camas tiene, precio, si dispone de servicio a la habitacion, etc.
             */

            int hab;

            Console.Write("Ingrese un Número de Habitacion (540 al 546): ");
            hab = int.Parse(Console.ReadLine());

            switch (hab)
            {
                case 540:
                    Console.WriteLine("-Habitacion 540:");
                    Console.WriteLine("         *4 Camas_*2 Baños");
                    Console.WriteLine("         *Servicio a la Habitacion hasta 12:00hs");
                    Console.WriteLine("         *Ventanas con vista al mar_*2 Ventiladores");
                    Console.WriteLine(" -Precio: $20.540,99");
                    break;
                case 541:
                    Console.WriteLine("-Habitacion 541:");
                    Console.WriteLine("         *1 Camas Matrimonial_*1 Baño");
                    Console.WriteLine("         *Servicio a la Habitacion 24hs");
                    Console.WriteLine("         *Ventanas con vista frente al mar_*1 Aire Acondicionado");
                    Console.WriteLine(" -Precio: $30.530");
                    break;
                case 542:
                    Console.WriteLine("-Habitacion 542:");
                    Console.WriteLine("         *1 Cama Cucheta_*1 Baño");
                    Console.WriteLine("         *Sin servicio a la Habitacion");
                    Console.WriteLine("         *2 Ventiladores");
                    Console.WriteLine(" -Precio: $15.000");
                    break;
                case 543:
                    Console.WriteLine("-Habitacion 543:"); 
                    Console.WriteLine("         *1 Cama Matrimonial de agua_*1 Baño");
                    Console.WriteLine("         *Servicio a la Habitacion hasta 00:00hs");
                    Console.WriteLine("         *Ventanas corrediza_*Sin aire Acondicionado");
                    Console.WriteLine(" -Precio: $40.399,99");
                    break;
                case 544:
                    Console.WriteLine("-Habitacion 544:");
                    Console.WriteLine("         *5 Camas_*2 Baños");
                    Console.WriteLine("         *Servicio a la Habitacion 24 hs");
                    Console.WriteLine("         *2 Ventiladores");
                    Console.WriteLine(" -Precio: $25.700");
                    break;
                case 545:
                    Console.WriteLine("-Habitacion 545:");
                    Console.WriteLine("         *4 Camas_*2 Baños");
                    Console.WriteLine("         *Sin servicio a la Habitacion");
                    Console.WriteLine("         *Aire Acondicionado");
                    Console.WriteLine(" -Precio: $20.000");
                    break;

                default:
                    Console.Write("*Habitacion no Disponible*");
                    break;
            }
            Console.ReadKey();

        }
    }
}
