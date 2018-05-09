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
            Console.WriteLine("Введите x: ");
            var x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень: ");
            var n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x+" в степени "+n+" = "+Math.Pow(x,n));
            Console.ReadKey();

        }
    }
}
