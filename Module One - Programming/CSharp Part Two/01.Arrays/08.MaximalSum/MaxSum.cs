using System;

//Write a program that finds the sequence of maximal sum in given array.

namespace _08.MaximalSum
{
    class MaxSum
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

            int currentSum = 0;
            int currentIndex = 0;
            int currentCount = 0;
            
            int bestSum = 0;
            int bestStart = 0;
            int bestCount = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (currentSum <= 0)
                {
                    currentIndex = i;
                    currentSum = 0;
                    currentCount = 0;
                }

                currentSum += numArray[i];
                currentCount++;

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = currentIndex;
                    bestCount = currentCount;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                if (i < bestCount -1)
                {
                    Console.Write("{0}, ", numArray[i + bestStart]);
                }
                else
                {
                    Console.WriteLine("{0}", numArray[i + bestStart]);
                }
            }
        }
    }
}
