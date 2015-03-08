using System;

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

namespace _04.Sub_stringInText
{
    class Substring
    {
        static int SearchText (string text, string substring)
        {
            string txt = text.ToLower();
            string substr = substring.ToLower();
            int counter = 1;
            int currentIndex = txt.IndexOf(substr);

            if (currentIndex == -1)
            {
                return currentIndex;
            }

            while (true)
            {
                currentIndex = txt.IndexOf(substr, currentIndex + substr.Length);

                if (currentIndex == -1)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
        static void Main()
        {
            Console.Write("Insert a string: ");
            string input = Console.ReadLine();
            Console.Write("Insert substring: ");
            string substring = Console.ReadLine();

            int numberOfOccurrences = SearchText(input, substring);
            Console.WriteLine(numberOfOccurrences);
        }
    }
}
