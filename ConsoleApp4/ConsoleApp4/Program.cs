using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 num, num_1;
            Console.WriteLine("Enter first number: ");
            num = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nEnter second number: ");
            num_1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("The result is: " + (num + num_1).ToString());
            Console.ReadKey();


        }
    }
}