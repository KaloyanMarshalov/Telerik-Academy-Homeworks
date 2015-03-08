using System;

//Write a program that prints an isosceles triangle of 9 copyright symbols ©. 

namespace _8.CopyrightSymbolTriangle
{
    class CopyrightSymbolTriangle
    {
        static void Main()
        {
            char copyrightSymbol = '\u00A9';
            Console.WriteLine("  {0}  ", copyrightSymbol);
            Console.WriteLine(" {0} {0} ", copyrightSymbol);
            Console.WriteLine("{0} {0} {0}", copyrightSymbol);
        }
    }
}
