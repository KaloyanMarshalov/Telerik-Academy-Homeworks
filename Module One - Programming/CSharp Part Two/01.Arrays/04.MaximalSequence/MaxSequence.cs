using System;

//Write a program that finds the maximal sequence of equal elements in an array.

namespace _04.MaximalSequence
{
    class MaxSequence
    {
        static void Main()
        {
            //I wrote the program using int arrays
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert elements of the array: ");
            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int bestSequence = 1;
            int bestElement = numArray[0];
            int currSequence = 1;

            for (int i = 1; i < numArray.Length; i++)
            {
                if (numArray[i-1] == numArray[i])
                {
                    currSequence++;
                }
                else
                {
                    currSequence = 1;
                }

                if (currSequence >= bestSequence)   //the sign must be >= so that the last max sequence is the best
                {
                    bestSequence = currSequence;
                    bestElement = numArray[i];
                }
            }

            for (int i = 0; i < bestSequence; i++)
            {
                if (i == bestSequence-1)
                {
                 
                Console.WriteLine("{0}", bestElement);   
                }
                else
                {
                    Console.Write("{0}, ", bestElement);
                }
            }
        }
    }
}
