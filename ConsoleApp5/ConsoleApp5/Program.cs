using System;

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
            int[,] matrixMLT = new int[n, n];
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
                    matrixMLT[i, j] = matrixRandom[i, j] * matrixRandom[i, j];
                    matrix3 = matrix3 + $"{matrixMLT[i, j]}\t";
                }
            }
            Console.WriteLine("First matrix: " +matrix1);
            Console.WriteLine("Second matrix: " + matrix2);
            Console.WriteLine("Multiply result: " + matrix3);
            Console.ReadKey();
        }
    }
}
