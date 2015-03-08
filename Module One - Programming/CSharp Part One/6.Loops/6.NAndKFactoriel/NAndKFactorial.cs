using System;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

namespace _6.NAndKFactorial
{
    class NAndKFactorial
    {
        static void Main()
        {
            Console.Write("Insert K (K > 1): ");
            int k = int.Parse(Console.ReadLine()); 
            Console.Write("Insert N (100 > N > {0}): ", k);
            int n = int.Parse(Console.ReadLine());

            int nFactorial = Factorial(n);
            int kFactorial = Factorial(k);

            double result = nFactorial / kFactorial;
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
