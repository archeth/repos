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
            Console.WriteLine("Enter first number: ");
            var number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter second number: ");
            var number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The result is: " + (number1 + number2).ToString());
            Console.ReadKey();


        }
    }
}