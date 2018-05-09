using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n;
            Console.WriteLine("Введите N ");
            n = Convert.ToInt64(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("\nМатрица: ");
            Random random = new Random();
            int rand;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rand = random.Next(0, 100);
                    matrix[i, j] = rand;
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМинимальное значение в строках: ");
            for (int i = 0; i < n; i++)
            {
                int minLine = matrix[i, 0];
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < minLine)
                    {
                        minLine = matrix[i, j];
                    }
                }
                Console.WriteLine("Строка {0}, значение: {1}", i, minLine);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
