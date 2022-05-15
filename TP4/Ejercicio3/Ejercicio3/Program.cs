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
            Console.WriteLine("TRABAJO PRACTICO N4");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N3");
            Console.WriteLine("");
            /*3. Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero,
              mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el
              segundo número es cero, escribirá "Error: No se puede dividir entre cero".*/

            int num, num2;

            Console.Write("Ingrese un Numero: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                Console.Write("La division de ambos es: " + num / num2);

            }
            else
            {
                Console.Write("Error: No se puede dividir entre cero");
            }

            Console.ReadKey();
        }
    }
}
