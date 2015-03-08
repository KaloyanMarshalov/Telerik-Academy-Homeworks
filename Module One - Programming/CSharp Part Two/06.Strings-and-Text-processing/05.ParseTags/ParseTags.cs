using System;
using System.Text;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
//to upper-case. The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.ParseTags
{
    class ParseTags
    {
        static string UpperCaseParse(string text)
        {
            StringBuilder parsedText = new StringBuilder();

            int openingIndex = text.IndexOf("<upcase>");
            int closingIndex = text.IndexOf("</upcase>");
            int startIndex = 0;
            if (openingIndex == -1)
            {
                return text;
            }

            while (true)
            {
                if (openingIndex == -1)
                {
                    break;
                }
                int upperLength = closingIndex - openingIndex - 8;
                int normalLength = openingIndex - startIndex;
                parsedText.Append(text.Substring(startIndex, normalLength));
                parsedText.Append(text.Substring(openingIndex + 8, upperLength).ToUpper());

                startIndex = closingIndex + 9;
                openingIndex = text.IndexOf("<upcase>", closingIndex + 9);
                closingIndex = text.IndexOf("</upcase>", closingIndex + 9);
                
            }
            int finalIndex = text.LastIndexOf("</upcase>");
            parsedText.Append(text.Substring(finalIndex + 9, text.Length - finalIndex - 9));
            return parsedText.ToString();
        }
        static void Main()
        {
            Console.Write("Insert string: ");
            string input = Console.ReadLine();

            Console.WriteLine(UpperCaseParse(input));
            //Console.WriteLine(UpperCaseParse("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."));
        }
    }
}
