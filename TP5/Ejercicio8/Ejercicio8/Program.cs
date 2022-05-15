using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TRABAJO PRACTICO N5");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N8");
            Console.WriteLine("");
            /*8-Crear un programa que simule una computadora muy rudimentaria. El ususario debera ingresar
             * dos numeros, despues de ingresar los numeros debera ingresar un operador matematico(+,-,/,* o %)
             * El programa debera devolver el resultado de operar con los dos numeros y el operador ingresado 
             * acompañado con un mensaje adecuado*/

            int num1, num2, suma, resta, mul, div, mod;
            char operador;

            Console.Write("Ingrese un Número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese Otro Número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un Operador Matematico (+,-,/,* o %): ");
            operador = char.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    suma = num1 + num2;
                    Console.Write("Operador (+): La Suma de los números es: "+ suma);
                    break;
                case '-':
                    resta = num1 - num2;
                    Console.Write("Operador (-): La Resta de los números es: "+ resta);
                    break;
                case '/':
                    div = num1 / num2;
                    Console.Write("Operador (/): La Division de los números es: "+ div);
                    break;
                case '*':
                    mul = num1 * num2;
                    Console.Write("Operador (*): La Multiplicacion de los números es: "+ mul);
                    break;
                case '%':
                    mod = num1 % num2;
                    Console.Write("Operador (%): El Módulo de los números es: "+ mod);
                    break;
                default:
                    Console.Write("Operador No Encontrado");
                    break;
            }


            Console.ReadKey();
        }
    }
}
