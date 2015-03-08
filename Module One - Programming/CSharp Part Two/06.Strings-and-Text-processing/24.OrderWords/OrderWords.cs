using System;
using System.Linq;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.Write("Insert a few words (separated by spaces): ");
            string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            Console.WriteLine("\nWords sorted in alphabetical order:\n{0}\n",
                string.Join("\n", words.Select(x => string.Format("- {0}", x))));
        }
    }
}
