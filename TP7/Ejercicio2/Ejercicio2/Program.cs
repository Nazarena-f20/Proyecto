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
            //2-Escribir un programa que pida al usuario un numero 
            //entero positivo y muestre por pantalla la cuenta atras desde ese numero hasta cero separados por coma.

            int num;

            Console.Write("Ingrese un Numero Entero Positivo: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("Cuenta Regresiva: ");

            for (int i = num; i >= 1; i--)
            {
                Console.Write(i + ",");   
            }

            Console.Write("0.");

            Console.ReadKey();
        }
    }
}
