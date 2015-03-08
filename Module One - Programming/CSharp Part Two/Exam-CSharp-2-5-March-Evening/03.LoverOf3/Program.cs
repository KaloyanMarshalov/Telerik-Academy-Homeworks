using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LoverOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            string dimensions = Console.ReadLine();
            int height = int.Parse(dimensions.Split(' ')[0]);
            int width = int.Parse(dimensions.Split(' ')[1]);
            var matrix = FillMatrix(width, height);

            int moves = int.Parse(Console.ReadLine());
            string[] movesArr = new string[moves];
            for (int i = 0; i < movesArr.Length; i++)
            {
                movesArr[i] = Console.ReadLine();
            }

            int currCol = 0;
            int currRow = height - 1;
            long sum = 0;

            for (int i = 0; i < movesArr.Length; i++)
            {
                string move = movesArr[i];
                
                string direction = move.Split(' ')[0];
                int movesAmmount = int.Parse(move.Split(' ')[1]);

                if (direction == "UR" || direction == "RU")
                {
                    for (int j = 0; j < movesAmmount; j++)
                    {
                        if (currRow >= height || currCol >= width || currRow < 0 || currCol < 0)
                        {
                            currCol--;
                            currRow++;
                            break;
                        }
                        sum += matrix[currRow, currCol];
                        matrix[currRow, currCol] = 0;
                        currCol++;
                        currRow--;
                        if (j + 1 == movesAmmount)
                        {
                            currCol--;
                            currRow++;
                            break;
                        }
                    }
                }
                else if (direction == "UL" || direction == "LU")
                {
                    for (int j = 0; j < movesAmmount; j++)
                    {
                        if (currRow >= height || currCol >= width || currRow < 0 || currCol < 0)
                        {
                            currCol++;
                            currRow++;
                            break;
                        }
                        sum += matrix[currRow, currCol];
                        matrix[currRow, currCol] = 0;
                        currCol--;
                        currRow--;
                        if (j + 1== movesAmmount)
                        {
                            currCol++;
                            currRow++;
                            break;
                        }
                    }
                }
                else if (direction == "DL" || direction == "LD")
                {
                    for (int j = 0; j < movesAmmount; j++)
                    {
                        if (currRow >= height || currCol >= width || currRow < 0 || currCol < 0)
                        {
                            currCol++;
                            currRow--;
                            break;
                        }
                        sum += matrix[currRow, currCol];
                        matrix[currRow, currCol] = 0;
                        currCol--;
                        currRow++;
                        if (j  + 1== movesAmmount)
                        {
                            currCol++;
                            currRow--;
                            break;
                        }
                    }
                }
                else if (direction == "DR" || direction == "RD")
                {
                    for (int j = 0; j < movesAmmount; j++)
                    {
                        if (currRow >= height || currCol >= width || currRow < 0 || currCol < 0)
                        {
                            currCol--;
                            currRow--;
                            break;
                        }
                        sum += matrix[currRow, currCol];
                        matrix[currRow, currCol] = 0;
                        currCol++;
                        currRow++;
                        if (j + 1== movesAmmount)
                        {
                            currCol--;
                            currRow--;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static int[,] FillMatrix(int width, int height)
        {
            int[,] matrix = new int[height, width];
            int counter = 0;
            int nextCounter = 3;
            int currentRow = 0;

            for (currentRow = height -1 ; currentRow >= 0; currentRow--)
            {
                for (int currCol = 0; currCol < width; currCol++)
                {
                    matrix[currentRow, currCol] = counter;

                    counter += 3;
                }
                counter = nextCounter;
                nextCounter += 3;
            }
            return matrix;
        }
    }
}
