using System;
using System.Globalization;

//Write a program that finds the biggest of three numbers.

namespace _5.BiggestOfThreeInts
{
    class BiggestInt
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("{0} is the biggest", num1);
                }
            }
            if (num2 > num1)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("{0} is the biggest", num2);
                }
            }
            if (num3 > num2)
            {
                if (num3 > num1)
                {
                    Console.WriteLine("{0} is the biggest", num3);
                }
            }
        }
    }
}
