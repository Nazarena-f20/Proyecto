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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N2");
            Console.WriteLine("");
            /*2. Crea un programa que multiplique dos números enteros de la siguiente forma: pedirá
              al usuario un primer número entero. Si el número que sé que teclee es 0, escribirá en
              pantalla "El producto de 0 por cualquier número es 0". Si se ha tecleado un número
              distinto de cero, se pedirá al usuario un segundo número y se mostrará el producto de
              ambos.*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.Write("El producto de 0 por cualquier número es 0");
            }
            else
            {
                if (num != 0)
                {
                    Console.Write("Ingrese otro Numero: ");
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.Write("El producto de 0 por cualquier número es 0");
                    }
                    else
                    {
                        Console.Write("El producto de ambos numeros es: " + num * num2);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
