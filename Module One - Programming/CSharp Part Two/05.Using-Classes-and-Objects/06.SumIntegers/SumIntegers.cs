using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static int CalculateSum(string integers)
        {
            int sum = 0;
            string[] numArray = integers.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in numArray)
            {
                sum += int.Parse(number);
            }
            return sum;
        }

        static void Main()
        {
            Console.Write("Insert positive integers, separated by space: ");
            string input = Console.ReadLine();

            int sumOfIntegers = CalculateSum(input);
            Console.WriteLine(sumOfIntegers);
        }
    }
}
