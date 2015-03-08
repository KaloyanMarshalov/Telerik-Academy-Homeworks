using System;
using System.Globalization;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

namespace _7.SortingInDescendingOrder
{
    class SortingDescOrder
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", num1, num3, num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0}, {1}, {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", num2, num3, num1);
                }
            }
            else if (num3 > num1 && num3 > num2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine("{0}, {1}, {2}", num3, num1, num2);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", num3, num2, num1);
                }
            }
        }
    }
}
