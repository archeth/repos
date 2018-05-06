using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите количество слагаемых: ");
            N = Convert.ToInt32(Console.ReadLine());
                while (N <= 0)
            {Console.WriteLine("Количество слагаемых должно быть больше нуля");
             Console.ReadKey();
                break;
            }
                while (N>0)
            {
                double[] Elements = new double[N];
                double Result = 0;

                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Введите " + (i + 1) + " число: ");
                    Elements[i] = Convert.ToDouble(Console.ReadLine());
                    Result += Elements[i];
                    Console.WriteLine("Сумма = " + Result);
                }
                Console.ReadKey();
                break;


            }
            
        }

    }
}
