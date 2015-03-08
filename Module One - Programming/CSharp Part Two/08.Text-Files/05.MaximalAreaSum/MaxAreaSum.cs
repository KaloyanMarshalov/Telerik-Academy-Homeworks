using System;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.

namespace _05.MaximalAreaSum
{
    class MaxAreaSum
    {
        static int[,] ReadMatrix(StreamReader textFileReader)
        {
            using (textFileReader)
            {
                int n = int.Parse(textFileReader.ReadLine());

                int[,] matrix = new int[n, n];

                string line = "";
                for (int row = 0; row < n; row++) 
                {
                    line = textFileReader.ReadLine();
                    string[] rowCells = line.Split(' ');
                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(rowCells[col]);
                    }
                }
                return matrix;
            }
        }
        static int MaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            int height = matrix.GetLength(0) - 1;// -1 because searching in 2x2 area
            int width =  matrix.GetLength(1) - 1;

            for (int row = 0; row < height; row++) 
            {
                for (int col = 0; col <width; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/Matrix.txt");
            int[,] matrix = ReadMatrix(reader);
            int maxSumInMatrix = MaxSum(matrix);

            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex5.txt");
            using (writer)
            {
                writer.WriteLine(maxSumInMatrix);
            }
        }
    }
}
