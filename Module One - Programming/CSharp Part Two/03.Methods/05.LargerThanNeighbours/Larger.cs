using System;

//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours 
//(when such exist).

namespace _05.LargerThanNeighbours
{
    class Larger
    {
        static bool CheckNeighbours(int[] numArray, int number)
        {
            int numberIndex = Array.IndexOf(numArray, number);

            if (number > numArray[numberIndex - 1] && number > numArray[numberIndex + 1] && numberIndex != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numArray = new int[n];
            Console.WriteLine("Insert the elements of the array");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Insert the number: ");
            int number = int.Parse(Console.ReadLine());
            if (numArray.Length < 3)
            {
                Console.WriteLine("Insufficient length of array");
            }
            else
            {
                bool isBigger = CheckNeighbours(numArray, number);
                Console.WriteLine(isBigger);
            }
        }
    }
}
