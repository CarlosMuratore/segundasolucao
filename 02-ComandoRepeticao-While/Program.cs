using System;

namespace _02_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <=10)
            {
                Console.WriteLine($"Contando: {i}");
                i++;
            }
            Console.WriteLine("--------------------");

            for ( int j = 11; j <=20; j++)
            {
                Console.WriteLine($"Contando: {j}");
            }
            Console.WriteLine("--------------------");

            int m = 0;
            while (m <= 10)
            {
                Console.WriteLine($"{m} x 4 = {m * 4}");
                m++;
            }
            Console.WriteLine("--------------------");

            for (int n = 0; n <= 10; n++)
            {
                Console.WriteLine($"{n} x 6 = {n * 6}");
            }


        }
    }
}