using System;

//Write a boolean expression that checks for given integer if it can be divided (without remainder)
//by 7 and 5 in the same time.

namespace _3.DividedBySevenAndFive
{
    class DividedBy7And5
    {
        static void Main()
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 5 == 0 && number % 7 == 0)
            {
                Console.WriteLine("The number {0} can be divided by 7 and 5 without remainder", number);
            }
            else
            {
                Console.WriteLine("The number {0} can't be divided by 7 and 5 without remainder", number);
            }
        }
    }
}
