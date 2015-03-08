using System;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].

namespace _10.NFactorial
{
    class NFactorial
    {
        static BigInteger Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        static void Main()
        {
            BigInteger[] factorialArray = new BigInteger[100];
            for (int i = 0; i < factorialArray.Length; i++)
            {
                factorialArray[i] = Factorial(i + 1);
            }
            Console.WriteLine(string.Join(", ", factorialArray));
        }
    }
}
