using System;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static string CensorText(string text, string forbiddenWords)
        {
            string[] words = forbiddenWords.Split(new string[]{", "}, StringSplitOptions.None);
            string censoredText = text;

            foreach (string word in words)
            {
                censoredText = censoredText.Replace(word, new string('*', word.Length));
            }
            return censoredText;
        }
        static void Main()
        {
            Console.Write("Insert a string: ");
            string input = Console.ReadLine();
            Console.Write("Insert forbidden words, separated by \", \"");
            string words = Console.ReadLine();

            //string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            //string words = "PHP, CLR, Microsoft"

            string censoredText = CensorText(input, words);
            Console.WriteLine(censoredText);
        }
    }
}
