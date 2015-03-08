using System;

//Write a program that finds the maximal increasing sequence in an array.

namespace _05.MaximalIncreasingSequence
{
    class MaxIncreasing
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

            int bestSequence = 1;
            int bestStart = numArray[0];
            int currSequence = 1;

            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i-1] + 1 == numArray[i])
                {
                    currSequence++;
                }
                else
                {
                    currSequence = 1;
                }

                if (currSequence >= bestSequence)
                {
                    bestSequence = currSequence;
                    bestStart = numArray[i - bestSequence + 1];
                }
            }

            for (int i = 0; i < bestSequence; i++)
            {
                if (i == bestSequence -1)
                {
                    Console.WriteLine("{0}", bestStart+i);
                }
                else
                {
                    Console.Write("{0}, ", bestStart+i);
                }
            }
        }
    }
}
