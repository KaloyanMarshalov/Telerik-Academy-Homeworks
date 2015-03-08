using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.

namespace _11.NumbersInRange
{
    class NumbersInRange
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNum = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("The amount numbers divided by 5 with remainder 0 in the range ({0}, {1}) is {2}", 
                                firstNum, secondNum, count);
        }
    }
}
