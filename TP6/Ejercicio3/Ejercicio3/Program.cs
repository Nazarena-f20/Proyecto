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
            Console.WriteLine("TRABAJO PRACTICO N6");
            Console.WriteLine("Nazarena Fuenzalida");
            Console.WriteLine("Ejercicio N3");
            Console.WriteLine("");

            /*Crea un programa que pida al usuario su código de usuario (un String) y su contraseña numérica (número
             * entero), el usuario y la contraseña correcta son epet52022 y 4567, al no ingresar el usuario o la contraseña
             * correcta deberá dar aviso con un mensaje para que el usuario corrija el error. Al introducir el usuario y
             * contraseña correcto emitir un mensaje que haga mención que se introdujo correctamente y saldrá del
             * programa. El usuario tendrá solo tres oportunidades, cumplida las tres oportunidades deberá emitir un
             * mensaje dando aviso y deberá salir el programa*/

            string usuario;
            int contraseña,  correcta = 4567, usuari, cinco = 52022;
            int us = 3;

            Console.Write("Ingrese el Nombre de Usuario: "); 
            usuario = Console.ReadLine();
            Console.Write("Junto con su Numero: ");
            usuari = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su Contraseña: ");
            contraseña = int.Parse(Console.ReadLine());

            if (usuario != "epet" || usuari != cinco || contraseña != correcta)
            {
                do
                {
                    if (usuario == "epet" && usuari == cinco && contraseña == correcta)
                    {
                        Console.WriteLine(" ");
                        Console.Write("'''CORRECTOS'''");
                        us = 0;
                    }
                    else
                    {
                        Console.WriteLine("INCORRECTO");
                        Console.WriteLine(" ");
                        Console.WriteLine("Tiene:" + us + " Intentos");
                        Console.WriteLine(" ");
                        Console.Write("Ingrese el Nombre de Usuario: ");
                        usuario = Console.ReadLine();
                        Console.Write("Junto con su Numero: ");
                        usuari = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese su Contraseña: ");
                        contraseña = int.Parse(Console.ReadLine());
                        if (us == 1)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("DEMASIADOS INTENTOS");
                        }
                        us = us - 1;
                    }
                
                } while (us >= 1);     
            }

            else
            {
                Console.WriteLine(" ");
                Console.Write("'''CORRECTOS'''");
                
            }
      
             
            Console.ReadKey();
        }
    }
}