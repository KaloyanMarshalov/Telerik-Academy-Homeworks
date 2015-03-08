using System;

//Write a program that reverses the words in given sentence.

namespace _13.ReverseSentence
{
    class Reverse
    {
        static string ReverseSentence(string text)
        {
            char lastSign = (char)text[text.Length - 1];
            text = text.Remove(text.Length - 1, 1);
            string[] words = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            string result = string.Join(" ", words) + lastSign;
            return result;
        }
        static void Main()
        {
            Console.Write("Insert a sentence: ");
            string sentence = Console.ReadLine();
            //string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(ReverseSentence(sentence));
        }
    }
}
