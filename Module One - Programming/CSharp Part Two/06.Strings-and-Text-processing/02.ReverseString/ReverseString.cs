using System;

//Write a program that reads a string, reverses it and prints the result at the console.

namespace _02.ReverseString
{
    class ReverseString
    {
        static string ReverseStrings(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            Console.Write("Insert a string: ");
            string text = Console.ReadLine();

            string reversed = ReverseStrings(text);
            Console.WriteLine(reversed);
        }
    }
}
