using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            //2. crea un programa que lea una letra tecleada por el usuario y diga si se trata de un signo de puntuacion
            // (.,;:), una cifra numerica (del 0 al 9) o algun otro caracater, 
            //usando "switch" (pista: habra que usar un dato de tipo "char")


            char let;

            Console.Write("Ingrese una letra: ");
            let = char.Parse(Console.ReadLine());

            switch (let)
            {
                case '0': case '1': case '2': case '3': case '4':  case '5': case '6': case '7':  case '8':  case '9':
            
                
                    Console.Write("La letra Ingresada es una cifra Numérica");
                    break;

                case '.': case ',': case ';': case ':':
                
                    Console.Write("La letra Ingresada es un signo de Puntuación");
                    break;  
                default:
                    Console.Write("La letra Ingresada es algun otro Caracter");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}
