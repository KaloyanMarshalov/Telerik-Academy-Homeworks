﻿using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

namespace _17.GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Insert a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert b: ");
            int b = int.Parse(Console.ReadLine());
            int gcd = GCD(a, b);
            Console.WriteLine("The greatest common divisor is: {0}", gcd);
        }
        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
    }
}
