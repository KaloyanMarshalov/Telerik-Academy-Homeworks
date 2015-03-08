using System;
/*
    Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:
    Example for n=4:
a)                    b)                    c)                  d)
1 	5 	9 	13        1   8    9   16       7 	11 	14 	16      1 	12 	11 	10
2 	6 	10 	14        2   7   10   15       4 	8 	12 	15      2 	13 	16 	9
3 	7 	11 	15        3   6   11   14       2 	5 	9 	13      3 	14 	15 	8
4 	8 	12 	16        4   5   12   13       1 	3 	6 	10      4 	5 	6 	7
 */
class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        // a)
        Console.WriteLine("The matrix from a):");
        //Fill the matrixA
        int value = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                matrix[row, col] = value;
                value++;
            }
            //Console.WriteLine();
        }
        //Print the matrix
        PrintMatrix(matrix);
        Console.WriteLine();
        
        
        // b)
        Console.WriteLine("The matrix from b):");
        //Fill the matrix
        value = 1;
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = value;
                }
                else
                {
                    matrix[n - row - 1, col] = value;
                }
                value++;
            }
        }
        //Print the matrix
        PrintMatrix(matrix);
        Console.WriteLine();

        
        // c)
        Console.WriteLine("The matrix from c):");
        //Fill the matrix
        value = 1;
        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                matrix[row + col, col] = value++;
            }
        }
        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row < n - col; row++)
            {
                matrix[row, col + row] = value++;
            }
        }
        //Print the matrix
        PrintMatrix(matrix);
        Console.WriteLine();
        
        
        // d)
        Console.WriteLine("The matrix from d)");
        //Fill the matrix
        value = 1;
        n = n - 1; 
        for (int index = 0; index <= n / 2; index++)
        {
            for (int row = index; row < n - index; row++)
            {
                matrix[row, index] = value++;
            }
            for (int col = index; col < n - index; col++)
            {
                matrix[n - index, col] = value++;
            }
            for (int row = n - index; row > index; row--)
            {
                matrix[row, n - index] = value++;
            }
            for (int col = n - index; col > index; col--)
            {
                matrix[index, col] = value++;
            }
        }
        if ((n & 1) == 0)
        {
            matrix[n / 2, n / 2] = value;
        }
        //Print the matrix
        PrintMatrix(matrix);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}