using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

namespace _06.StringLength
{
    class StringLength
    {
        static string AddAsterix(string text)
        {
            if (text.Length == 20)
            {
                return text;
            }
            StringBuilder extendedString = new StringBuilder();
            extendedString.Append(text);
            while (extendedString.Length < 20)
            {
                extendedString.Append("*");
            }
            return extendedString.ToString();
        }
        static void Main()
        {
            Console.Write("Insert string: ");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("Error! The string must have 20 or less characters!");
            }
            else
            {
                string modifiedString = AddAsterix(text);
                Console.WriteLine(modifiedString);
            }
        }
    }
}
