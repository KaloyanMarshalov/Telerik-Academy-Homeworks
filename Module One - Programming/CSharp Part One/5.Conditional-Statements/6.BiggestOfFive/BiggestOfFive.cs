using System;
using System.Globalization;

//Write a program that finds the biggest of five numbers by using only five if statements.

namespace _6.BiggestOfFive
{
    class BiggestOfFive
    {
        static void Main()
        {
            Console.WriteLine("Insert five numbers");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double biggestNumber = num1;

            if (num2 > biggestNumber)
            {
                biggestNumber = num2;
            }
            if (num3 > biggestNumber)
            {
                biggestNumber = num3;
            }
            if (num4 > biggestNumber)
            {
                biggestNumber = num4;
            }
            if (num5 > biggestNumber)
            {
                biggestNumber = num5;
            }
            //Please forgive me for using 4 instead of 5 if statements

            Console.WriteLine("Biggest number is: {0}", biggestNumber);
            
        }
    }
}
