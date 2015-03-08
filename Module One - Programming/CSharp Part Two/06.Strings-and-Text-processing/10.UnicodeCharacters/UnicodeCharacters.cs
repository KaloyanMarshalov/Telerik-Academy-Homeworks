using System;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static string ConvertLiterals(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (var letter in text)
            {
                result.Append(String.Format("\\u{0:X4}", (int)letter));
            }

            return result.ToString();
        }
        static void Main()
        {
            Console.Write("Insert text: ");
            string input = Console.ReadLine();
            //string input = "SomeText!";

            string output = ConvertLiterals(input);
            Console.WriteLine(output);
        }
    }
}
