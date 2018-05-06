using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 x, n;
            int y = 1;
            Console.WriteLine("Введите x: ");
            x = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            n = Convert.ToInt64(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(x + " в степени " + n + " = " + y);
            }
            else
            { Console.WriteLine(x+" в степени "+n+" = "+Math.Pow(x,n)); }
            Console.ReadKey();

        }
    }
}
