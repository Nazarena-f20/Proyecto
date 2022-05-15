using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3-Escribir un programa que pida al usuario un numero entero y muestre por pantalla un triangulo rectangulo
            //como el de abajo, de altura el numero introducido.

            int num;
            string po = "*";

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num ; i++)
            {
                Console.WriteLine(po);
                po = po + "*";
                
            }


            Console.ReadKey();
        }
    }
}
