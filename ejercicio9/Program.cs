
using System;

namespace ejercicio9
{
     class Program
    {
        static void Main(string[] args)
        {

            double numeros = 1;
            double suma = 0;

            double c = 0;
            do
            {

                Console.WriteLine("Introduce un numero entero");
                numeros = double.Parse(Console.ReadLine());
                if (numeros !=0)
                {
                    suma = suma + numeros;

                    c = c + 1;
                }
               
            } while (numeros != 0);
            Console.WriteLine(" La suma de los numeros es de :  " + suma);

            Console.WriteLine("EL PROMEDIO DE LOS NUMEROS INGRESADOS ES: " + suma / c);
          










        }
    }
}
