using System;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que lea exactamente 8 números y luego escriba la suma de todos ellos


            int numeros;
            int  suma  = 0;
            int i;

            Console.WriteLine(" Introducir 8 numeros: ");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Introduce un numero entero");
                numeros = int.Parse(Console.ReadLine());
                suma = suma + numeros;
            }
                    Console.WriteLine(" La suma de los numeros es de :  " + suma);
            Console.ReadKey();  

            
    }
    }
}
