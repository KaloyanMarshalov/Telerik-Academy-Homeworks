using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

namespace _5.SumOfXAndN
{
    class SumOfXAndN
    {
        static void Main()
        {
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert X: ", n);
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += Factorial(n) / Math.Pow(x, i);
            }
            Console.WriteLine("{0:0.00000}", sum);
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
