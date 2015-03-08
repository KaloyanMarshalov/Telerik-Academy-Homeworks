using System;

//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

namespace _9.nNumbers
{
    class nNumbers
    {
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert number {0}: ", i);
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }
            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
