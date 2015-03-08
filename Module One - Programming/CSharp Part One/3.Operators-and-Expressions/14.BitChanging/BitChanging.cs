using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position 
//p from the binary representation of n while preserving all other bits in n.

namespace _14.BitChanging
{
    class BitChanging
    {
        static void Main()
        {
            Console.Write("Insert number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert postion p: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Insert value v (1 or 0): ");
            int v = int.Parse(Console.ReadLine());
            int newNumber;

            Console.WriteLine("Number before: {0}", n);
            if ((n >> p) == 1)
            {
                newNumber = n & (v << p);
            }
            else
            {
                newNumber = n | (v << p);
            }
            Console.WriteLine("Number after: {0}", newNumber);
        }
    }
}
