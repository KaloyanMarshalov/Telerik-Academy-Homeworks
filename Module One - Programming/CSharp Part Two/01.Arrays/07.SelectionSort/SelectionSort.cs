using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert elements of the array: ");
            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int temp;
            int minIndex;
            for (int i = 0; i < numArray.Length-1; i++)
            {
                minIndex = i;
                for (int j = i+1; j < numArray.Length; j++)
                {
                    if (numArray[j] < numArray[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    temp = numArray[i];
                    numArray[i] = numArray[minIndex];
                    numArray[minIndex] = temp;
                }
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                if (i == numArray.Length-1)
                {
                    Console.WriteLine("{0}", numArray[i]);
                }
                else
                {
                    Console.Write("{0}, ", numArray[i]);
                }
            }
        }
    }
}
