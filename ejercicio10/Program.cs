using System;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que lea un número entero por teclado y que calcule su factorial.




                int x;
                double fact = 1;

                Console.WriteLine("Escriba el número: ");
                x= int.Parse(Console.ReadLine());
                while (x > 1) fact *= x--;
                Console.WriteLine("Factorial = : " + fact);

            }

        }
    }

