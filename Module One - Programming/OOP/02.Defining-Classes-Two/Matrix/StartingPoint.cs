using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class StartingPoint
    {
        static void Main()
        {
            Matrix<int> testMatrix = new Matrix<int>(5, 5); 
            testMatrix[2, 1] = 5; 
            Console.WriteLine("Matrix[2,1] = {0}", testMatrix[2, 1]);


            Matrix<int> matrix1 = new Matrix<int>(3, 3); //two matrices for testing +, - and *
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = (i + 3) * (j + 1) + 5;
                    matrix2[i, j] = (i + 1) * (j + 2);
                }
            }

            Console.WriteLine("Matrix 1:\n{0}", matrix1);
            Console.WriteLine("Matrix 2:\n{0}", matrix2);

            Matrix<int> resultOfAddition = matrix1 + matrix2;
            Matrix<int> resultOfSubtraction = matrix1 - matrix2;
            Matrix<int> resultOfMultiplication = matrix1 * matrix2;

            Console.WriteLine("Matrix1 + Matrix2 =\n{0}", resultOfAddition);
            Console.WriteLine("Matrix1 - Matrix2 =\n{0}", resultOfSubtraction);
            Console.WriteLine("Matrix1 * Matrix2 =\n{0}", resultOfMultiplication);

            checkMatrix(matrix1);
            matrix1[0, 0] = 0;
            checkMatrix(matrix1);
        }
        static void checkMatrix(Matrix<int> matrix) //could not do it with Matrix<T>, would appreciate a solution :).
        {
            if (matrix)
            {
                Console.WriteLine("Does not contain zero");
            }
            else
            {
                Console.WriteLine("Contains zero");
            }
        }
    }
}
