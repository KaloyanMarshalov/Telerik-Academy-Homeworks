using System;

//Write an expression that checks if given integer is odd or even.

namespace _1.OddOrEvenInteger
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number {0} is even", number);
            }
            else
            {
                Console.WriteLine("The number {0} is odd", number);
            }
        }
    }
}
