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
            Console.WriteLine("TRABAJO PRACTICO N3");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N7");
            Console.WriteLine("");

            /*Escribi un programa que solicite ingresar un numero de usuario 
             * y una contraseña. Si el nombre es "epet5" y la contraseña es "escuela", mostrar
             * en pantalla "Usuario y contraseña correctos.Puede ingresar a la escuela".
             * Si el nombre o la contraseña no coinciden, mostrar "Acceso denegado"*/

            string usuario = "epet5", contraseña = "escuela";
            string us, con;

            Console.Write("Ingrese su Usuario: ");
            us = Console.ReadLine();

            Console.Write("Ingrese su contraseña: ");
            con = Console.ReadLine();

            if (us == usuario && con == contraseña)
            {
                Console.Write("Usuario y Contraseña correctos. Puede ingresar a la escuela");
            }
            else
            {
                Console.Write("Acceso Denegado");
            }

            Console.ReadKey();
        }
    }
}
