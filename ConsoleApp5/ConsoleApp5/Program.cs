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
            long n;
            var matrix1 = string.Empty;
            var matrix2 = string.Empty;
            var matrix3 = string.Empty;
            Console.WriteLine("Введите N ");
            n = Convert.ToInt64(Console.ReadLine());
            int[,] matrixRandom = new int[n, n];
            int[,] matrixSUM = new int[n, n];
            Random random = new Random();
            int rand;
            for (int i = 0; i < n; i++)

            {
                for (int j = 0; j < n; j++)

                {
                    rand = random.Next(0, 100);
                    matrixRandom[i, j] = rand;
                    matrix1 = matrix1 + $"{matrixRandom[i, j]}\t";
                    matrix2 = matrix2 + $"{matrixRandom[i, j]}\t";
                    matrixSUM[i, j] = matrixRandom[i, j] + matrixRandom[i, j];
                    matrix3 = matrix3 + $"{matrixSUM[i, j]}\t";

                }
                
            }

            Console.WriteLine("Матрица 1: " +matrix1);
            Console.WriteLine("Матрица 2: " + matrix2);
            Console.WriteLine("Сумма    : " + matrix3);
            Console.ReadKey();
        }
    }
}
