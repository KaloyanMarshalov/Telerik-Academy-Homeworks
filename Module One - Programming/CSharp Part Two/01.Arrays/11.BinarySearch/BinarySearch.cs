using System;

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert the searched element: ");
            int element = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert elements of the array: ");
            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numArray);

            int minI = 0;
            int maxI = numArray.Length-1;
            int midI = 0;

            while (maxI >= minI)
            {
                midI = (minI + maxI) / 2;
                if (numArray[midI] == element)
                {
                    Console.WriteLine(midI);
                    break;
                }
                else if (numArray[midI] < element)
                {
                    minI = midI + 1;
                }
                else
                {
                    maxI = midI - 1;
                }
            }
        }
    }
}
