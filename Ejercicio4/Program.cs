using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num =0;
            int suma =0;

            do
            {
                Console.WriteLine("dijite un numero: ");
                num = int.Parse(Console.ReadLine());
                suma = suma + num;
            }while (num != 0);
            Console.WriteLine("La suma es : "+suma);
            Console.ReadKey();




        }

    }
}
