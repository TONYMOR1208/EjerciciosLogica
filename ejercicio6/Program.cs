
using System;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeros=0;
            int suma = 0;


            do
            {

                Console.WriteLine("Introduce un numero entero");
                numeros = int.Parse(Console.ReadLine());
                suma = suma + numeros;


            } while (numeros!=0);


            Console.WriteLine(" La suma de los numeros es de :  " + suma);
        
        
      

        }
    }
}
