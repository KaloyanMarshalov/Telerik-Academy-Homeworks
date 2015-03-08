using System;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, 
//separated by a space.

namespace _1.PrintOneToN
{
    class OneToN
    {
        static void Main()
        {
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
