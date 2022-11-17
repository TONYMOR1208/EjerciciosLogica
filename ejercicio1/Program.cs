using System;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Ejercicio 1 
			//Crear un programa que lea dos números y que escriba el mayor de los dos.
			int numero_1, numero_2;
			 Console.WriteLine("Dijite el primer numero");
			 numero_1= int.Parse(Console.ReadLine());
			 Console.WriteLine("Dijite el segundo numero");
			numero_2 = int.Parse(Console.ReadLine());
			if (numero_1 > numero_2) 
			{

				Console.WriteLine("El primer numero es el mayor");

            }
			else


		if  (numero_2 > numero_1 )
			{
				Console.WriteLine("El segundo numero es el mayor");

			}
			

		}
    }
}
