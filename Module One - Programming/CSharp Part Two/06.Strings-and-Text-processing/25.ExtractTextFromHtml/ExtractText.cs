using System;
using System.Text.RegularExpressions;

namespace _25.ExtractTextFromHtml
{
    class ExtractText
    {
        static void Main()
        {
            //string htmlText = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            Console.Write("Insert html text: ");
            string htmlText = Console.ReadLine();

            foreach (Match item in Regex.Matches(htmlText, "(?<=^|>)[^><]+?(?=<|$)"))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
