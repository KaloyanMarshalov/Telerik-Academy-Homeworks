using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1	8 9	16
//2	7 10 15
//3	6 11 14
//4	5 12 13

namespace _01.MatrixFill_B
{
    class MatrixFill
    {
        static void Main()
        {
            //Initialize the matrix
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int counter = 1;

            //Fill the matrix
            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = n-1; row >= 0; row--)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
            }

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
