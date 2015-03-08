using System;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            // Read the matrix dimensions
            Console.Write("Insert number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Insert number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            // Allocate the matrix
            int[,] matrix = new int[rows, cols];

            // Enter the matrix elements
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    int element = int.Parse(Console.ReadLine());
                    matrix[row, col] = element;
                }
            }

            //int[,] matrix = 
            //{
            //    {1, 2, 3, 4, 5, 6, 7, 9, 8},
            //    {2, 3, 1, 2, 4, 1, 2, 5, 2},
            //    {1, 3, 1, 2, 6, 1, 7, 8, 1},
            //    {1, 3, 9, 9, 5, 6, 8, 8, 7},
            //    {2, 8, 9, 9, 1, 2, 3, 1, 1}
            //};

            //Find the maximal platform 3x3
            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            int matrixWidth = matrix.GetLength(1);
            int matrixHeight = matrix.GetLength(0);

            for (int row = 0; row < matrixHeight - 2; row++)
            {
                for (int col = 0; col < matrixWidth - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                   + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                   + matrix[row + 2, col] + matrix[row + 2, col + 2] + matrix[row + 2, col + 2];

                    if (currentSum> bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("Best sum: {0}", bestSum);
            //Print the result
            for (int row = bestRow; row < bestRow + 3; row++)
            {
                for (int col = bestCol; col < bestCol + 3; col++)
                {
                    Console.Write("{0} ", matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
