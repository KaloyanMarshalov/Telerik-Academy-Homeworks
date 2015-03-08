using System;

//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
//Cn = 1/n+1(2n n) = (2n)! / (n+1)! * n! for n>=0
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

namespace _8.CatalanNumber
{
    class CatalanNumber
    {
        static void Main()
        {
            Console.Write("Insert n (100 >= n >= 1): ");
            int n = int.Parse(Console.ReadLine());
            int catalanNum = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
            Console.WriteLine(catalanNum);
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
