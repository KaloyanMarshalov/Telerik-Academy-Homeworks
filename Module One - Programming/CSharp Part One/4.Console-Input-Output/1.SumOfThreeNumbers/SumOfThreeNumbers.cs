using System;

//Write a program that reads 3 integer numbers from the console and prints their sum.

namespace _1.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
