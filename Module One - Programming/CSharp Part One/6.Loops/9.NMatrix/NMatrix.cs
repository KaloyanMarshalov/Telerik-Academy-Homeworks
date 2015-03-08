using System;

//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. 
//Use two nested loops.
// n = 3
// 1 2 3
// 2 3 4
// 3 4 5
namespace _9.NMatrix
{
    class NMatrix
    {
        static void Main()
        {
            Console.Write("Inser n (n <= 20): ");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < row + n; col++)
                {
                    Console.Write("{0} ", col);
                }
                Console.WriteLine();
            }
        }
    }
}
