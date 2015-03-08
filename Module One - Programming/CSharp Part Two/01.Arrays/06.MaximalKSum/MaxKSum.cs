using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

namespace _06.MaximalKSum
{
    class MaxKSum
    {
        static void Main()
        {
            Console.Write("Insert N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert K: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert elements of the array: ");
            int[] numArray = new int[n];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int bestSum = 0;
            int currSum = 0;
            int bestStartIndex = 0;

            for (int i = 0; i <= numArray.Length - k; i++)
            {
                //find the sum of K elements
                for (int j = 0; j < k; j++)
                {
                    currSum += numArray[i + j];
                }

                if (currSum >= bestSum)
                {
                    bestSum = currSum;
                    bestStartIndex = i;
                }
                currSum = 0;
            }

            //print the result
            Console.WriteLine("The best sum is: {0}", bestSum);
            for (int i = 0; i < k; i++)
            {
                if (i == k-1)
                {
                    Console.WriteLine("{0}", numArray[bestStartIndex + i]);
                }
                else
                {
                    Console.Write("{0}, ", numArray[bestStartIndex + i]);
                }
            }
        }
    }
}
