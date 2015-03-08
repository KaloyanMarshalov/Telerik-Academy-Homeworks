using System;

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the 
//\u00XX syntax, and then print it.

namespace _4.UnicodeSymbol
{
    class UnicodeSymbol
    {
        static void Main()
        {
            char symbol = '\u002A';
            Console.WriteLine(symbol);
        }
    }
}
