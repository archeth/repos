using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n;
            Console.WriteLine("Введите N ");
            n = Convert.ToInt64(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            Console.WriteLine("Матрица 1: ");
            Random random1 = new Random();
            int rand1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rand1 = random1.Next(0, 100);
                    matrix1[i, j] = rand1;
                    Console.Write("{0}\t", matrix1[i, j]);
                }
                Console.WriteLine();
            }

            int[,] matrix2 = new int[n, n];
            Console.WriteLine("Матрица 2: ");
            Random random2 = new Random();
            int rand2;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    rand2 = random2.Next(0, 100);
                    matrix2[x, y] = rand2;
                    Console.Write("{0}\t", matrix2[x, y]);
                }
                Console.WriteLine();
            }
            int[,] matrixSUM = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            Console.WriteLine("Сумма матриц: ");
            for (int c = 0; c < matrix1.GetLength(0); c++)
            {
                for (int z = 0; z < matrix2.GetLength(1); z++)
                {
                    matrixSUM[c, z] = matrix1[c, z] + matrix2[c, z];
                    Console.Write("{0}\t", matrixSUM[c, z]);
                }
                Console.WriteLine();
            }       
            Console.ReadKey();
        }
    }
}
