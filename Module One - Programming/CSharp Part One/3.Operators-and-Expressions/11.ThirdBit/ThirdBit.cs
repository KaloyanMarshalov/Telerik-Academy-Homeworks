using System;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

namespace _11.ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            if ((number >> 3 & 1) == 1)
            {
                Console.WriteLine("The number {0}'s third bit is 1", number);
            }
            else
            {
                Console.WriteLine("The number {0}'s third bit is 0", number);
            }
            
        }
    }
}
