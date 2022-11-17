using System;

namespace ejercicio7
{
     class Program
    {
        static void Main(string[] args)
       {
            //Escribir un programa que lea tres números e indique el tipo de triángulo que forman (isósceles, equilatero, escaleno).
            //Permitir que se pueda repetir indefinidamente si el usuario lo desea (que el ordenador pregunte ¿Quiere continuar?
            // y la persona pueda responder S ó N) 



            int x;
            int y;
            int z;

            char respuesta;

            do
            {
                Console.WriteLine("Escribe el primer lado");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEscribe el segundo lado");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEscribe el tercer lado");
                z = int.Parse(Console.ReadLine());
                Console.WriteLine("\n\n\n");


                if ((x + y > z) && (x + z > y) && (y + z) > x)
                {

                    if (x == y && x == z) Console.WriteLine("Equilátero");

                    else

                    if (x == y || x == z || y == z) Console.WriteLine("Isósceles");

                    else Console.WriteLine("Escaleno");
                }
                else

                    Console.WriteLine("Esos números no forman un triángulo");

                Console.WriteLine("\n¿Desea continuar (S/N)?)");

                respuesta = (Console.ReadLine()[0]);
            } while (respuesta!='N' && respuesta!='n'); 
        }
    }
    }

