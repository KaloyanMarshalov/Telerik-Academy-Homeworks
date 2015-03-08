using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//7 11 14 16
//4	8 12 15
//2	5 9	13
//1	3 6 10

namespace _01.MatrixFill_C
{
    class MatrixFill
    {
        static void Main()
        {
            //Initialize the matrix
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());

            
            //Print the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
