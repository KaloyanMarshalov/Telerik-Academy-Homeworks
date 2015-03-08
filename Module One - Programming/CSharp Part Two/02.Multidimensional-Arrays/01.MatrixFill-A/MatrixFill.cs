using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//1 5 9 13
//2 6 10 14
//3 7 11 15
//4 8 12 16

namespace _01.MatrixFill_A
{
    class MatrixFill
    {
        static void Main()
        {
            //Intialize the matrix
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int counter = 1;
            
            //Fill the matrix
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }    
            }

            //Print the matrix
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0} ", matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
