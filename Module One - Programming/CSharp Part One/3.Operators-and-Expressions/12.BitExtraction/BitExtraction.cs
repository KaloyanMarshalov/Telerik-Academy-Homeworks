using System;

//Write an expression that extracts from given integer n the value of given bit at index p.

namespace _12.BitExtraction
{
    class BitExtraction
    {
        static void Main()
        {
            Console.Write("Insert integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert bit number: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("The bit at {0} of the number {1} is: {2}", p, n, n >> p);
        }
    }
}
