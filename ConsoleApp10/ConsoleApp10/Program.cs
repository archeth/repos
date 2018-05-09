using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            String words = Console.ReadLine();
            String[] arr = words.Split(new char[] { ',', '.', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов в тексте: {0}", arr.Length);
            Console.ReadKey();
        }
    }
}
