using System;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int VARIABLE;

            Console.WriteLine("Dijite un numero");

            VARIABLE = int.Parse(Console.ReadLine());
            
            if (VARIABLE % 2 == 0)
            {

                Console.WriteLine("El numero "+ VARIABLE+ " es par");
            }
           else
                Console.WriteLine("El numero "+ VARIABLE+ " es impar");
         
       
        }
    }
}
