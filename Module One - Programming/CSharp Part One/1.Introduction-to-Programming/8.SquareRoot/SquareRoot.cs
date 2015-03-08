using System;

//Create a console application that calculates and prints the square root of the number 12345.

namespace NumberRaisedByTwo
{
    class SquareRoot
    {
        static void Main()
        {
            int raisedNumber = (int)Math.Pow(12345, 2);
            Console.WriteLine(raisedNumber);
        }
    }
}
