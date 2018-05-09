using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var words = Console.ReadLine();
            String[] arr = words.Split(new char[] {',', '.', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Количество слов: {0}", arr.Length);
            Console.ReadKey();
        }
        static Dictionary<string, int> CountWords(string sentence)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var words = sentence.Split(new char[] { ',', '.', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var elem in words)
            {
                if (!dict.ContainsKey(elem))
                {
                    dict.Add(elem, 1);
                }
                else
                {
                    dict[elem]++;
                }
            }
            return dict;
            Console.WriteLine("Количество слов: {0}", dict);
            Console.ReadKey();
        }
    }
}
