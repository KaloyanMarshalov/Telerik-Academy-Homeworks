using System;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

namespace _7.FactorialCalculations
{
    class FactorialCalculations
    {
        static void Main()
        {
            Console.Write("Insert K (K > 1): ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Insert N (100 > N > {0}): ", k);
            int n = int.Parse(Console.ReadLine());

            int nFactorial = Factorial(n);
            int kFactorial = Factorial(k);
            int nMinKFactorial = Factorial(n - k);
            int result = nFactorial / (kFactorial * nMinKFactorial);
            Console.WriteLine(result);
        }
        static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
