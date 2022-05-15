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
            Console.WriteLine("TRABAJO PRACTICO N1");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N6");
            Console.WriteLine("");
            /*Crear un programa donde el usuario ingrese dos números (a y b), el mismo
             deberá mostrar el resultado de las operaciones (a+b)*(a-b) y el resultado de la
             operación a^2-b^2.*/

            float num1;
            float num2;
            float resul;
            float resul2;

            Console.Write("Ingrese un Numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");

            resul = (num1 + num2) * (num1 - num2);
            resul2 = (num1 * num1) - (num2 * num2);

            Console.WriteLine("El Resultado de la operacion (a+b)*(a-b) es: " + resul);
            Console.WriteLine("El Resultado de la operacion a^2 - b^2 es: " + resul2);


            Console.ReadKey();
        }
    }
}
