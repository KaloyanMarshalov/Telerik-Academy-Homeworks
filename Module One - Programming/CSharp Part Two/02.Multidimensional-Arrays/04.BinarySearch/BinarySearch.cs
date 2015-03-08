using System;

//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert K: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert the members of the array");
            int[] numArray = new int[n];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numArray);
            int index = Array.BinarySearch(numArray, k);
            if (index >= 0)
            {
                Console.WriteLine("Element found! Index: {0}", index);
            }
            else
            {
                if (index == -1)
                {
                    Console.WriteLine("Element not found!");
                }
                else
                {
                    Console.WriteLine("Found a smaller element to K! Index: {0}", Math.Abs(index + 2));
                }
            }
        }
    }
}
