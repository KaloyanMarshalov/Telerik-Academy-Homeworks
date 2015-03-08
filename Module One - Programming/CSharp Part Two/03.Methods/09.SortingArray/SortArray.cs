using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

namespace _09.SortingArray
{
    class SortArray
    {
        static int FindElement(int[] numArray, int startIndex, int swapIndex = 0)
        {
            int maxIndex = startIndex;

            for (int i = startIndex; i <= numArray.Length; i++)
                if (numArray[maxIndex] < numArray[i])
                    maxIndex = i;

            int temp = numArray[swapIndex];
            numArray[swapIndex] = numArray[maxIndex];
            numArray[maxIndex] = temp;

            return numArray[swapIndex];
        }
        static int[] SortDescending(int[] numArray)
        {
            int size = numArray.Length;
            int[] sorted = new int[size];

            for (int i = 0; i < size; i++)
                sorted[i] = FindElement(numArray, i, i);

            return sorted;
        }
        static int[] SortAscending(int[] numArray)
        {
            int size = numArray.Length;
            int[] sorted = new int[size];

            for (int i = size - 1; i >= 0; i--)
                sorted[i] = FindElement(numArray, 0, i);

            return sorted;
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

            Console.Write("Insert starting index: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMax element in interval [{0}, {1}] -> {2}", startIndex, FindElement(numArray, startIndex));

            Console.WriteLine("\nNumbers in Ascending order: {0}", string.Join(" ", SortAscending(numArray)));

            Console.WriteLine("Numbers in Descending order: {0}\n", string.Join(" ", SortDescending(numArray)));
        }
    }
}
