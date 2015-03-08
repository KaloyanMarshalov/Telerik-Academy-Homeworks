using System;

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci 
//sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());

            ulong num1 = 0;
            ulong num2 = 1;
            ulong currentNum = 0;

            Console.Write("{0}, {1}", num1, num2);

            for (int i = 0; i < n; i++)
            {
                currentNum = num1 + num2;
                num1 = num2;
                num2 = currentNum;
                Console.Write(", {0}", currentNum);
                if (i == n - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
