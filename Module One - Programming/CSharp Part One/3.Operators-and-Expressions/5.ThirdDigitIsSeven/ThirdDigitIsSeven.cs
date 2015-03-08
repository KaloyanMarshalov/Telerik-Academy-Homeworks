using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

namespace _5.ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main()
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 1000 >= 700 && number % 1000 <= 799)
            {
                Console.WriteLine("The number {0}'s third digit is 7", number);
            }
            else
            {
                Console.WriteLine("The number {0}'s third digit isn't 7", number);
            }
        }
    }
}
