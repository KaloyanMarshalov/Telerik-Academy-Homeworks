using System;

//Write a program that finds the most frequent number in an array.

namespace _09.FrequentNumber
{
    class FrequentNumber
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

            Array.Sort(numArray);

            int currentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i] == numArray[i-1])
                {
                    currentLength++;
                    currentStart = i;
                    if (currentLength> bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            Console.WriteLine("{0} ({1} times)", numArray[bestStart], bestLength);
        }
    }
}
