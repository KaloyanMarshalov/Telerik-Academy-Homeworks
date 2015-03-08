using System;
using System.Linq;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            Console.Write("Insert text: ");
            string text = Console.ReadLine();

            MatchCollection words = Regex.Matches(text, @"\b\w+\b");

            Console.WriteLine("Extracted palindromes: ");

            foreach (var word in words)
            {
                if (IsPalindrome(word.ToString()))
                {
                    Console.WriteLine("- " + word);
                }
            }

            Console.WriteLine();
        }

        static bool IsPalindrome(string word)
        {
            return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
        }
    }
}
