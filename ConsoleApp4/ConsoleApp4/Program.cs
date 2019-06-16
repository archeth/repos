using System;

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
            Console.WriteLine(@"Select the arithmetic operation:
            - addition (enter 1)
            - subtraction (enter 2)
            - multiply (enter 3)
            - division (enter 4)");
            var operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("The result is {0} ", number1 + number2);
            }
            if (operation == 2)
            {
                Console.WriteLine("The result is {0} ", number1 - number2);
            }
            if (operation == 3)
            {
                Console.WriteLine("The result is {0} ", number1 * number2);
            }
            if (operation == 4)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Division by zero is disallowed");
                }
                else
                {
                    Console.WriteLine("The result is {0} ", number1 / number2);
                }
            }
            
            Console.ReadKey();
        }
    }
}