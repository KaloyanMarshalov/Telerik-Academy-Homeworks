using System;

//Find online more information about ASCII (American Standard Code for Information Interchange) 
//and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

namespace _14.EntireASCIIPrint
{
    class PrintASCII
    {
        static void Main()
        {
            char currentSymbol;
            for (int i = 0; i < 256; i++)
            {
                currentSymbol = (char)i;
                Console.WriteLine(currentSymbol);
            }
        }
    }
}
