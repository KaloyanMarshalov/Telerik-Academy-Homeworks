using System;
using System.Globalization;

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

namespace _7.SumOfFiveNums
{
    class SumOfFive
    {
        static void Main()
        {
            Console.Write("Insert 5 numbers, separated by a space: ");
            string numbersString = Console.ReadLine();
            string[] numbersArr = numbersString.Split(' ');
            double sum = 0;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                sum += double.Parse(numbersArr[i], CultureInfo.InvariantCulture);
            }
            Console.WriteLine(sum);
        }
    }
}
