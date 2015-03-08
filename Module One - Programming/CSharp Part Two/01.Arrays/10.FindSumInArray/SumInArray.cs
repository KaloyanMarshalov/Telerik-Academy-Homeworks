using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present).

namespace _10.FindSumInArray
{
    class SumInArray
    {
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert the sum S: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert elements of the array: ");
            int[] numArray = new int[n];

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = 0;
            int currentIndex = 0;


            for (int i = 0; i < numArray.Length; i++)
            {
                currentSum += numArray[i];
                currentIndex = i;

                if (currentSum == sum)
                {
                    Console.WriteLine("{0}", numArray[i]);
                    break;
                }

                for (int j =  i + 1; j < numArray.Length; j++)  //cycle trough the array from the next element until the end of the array
                {
                    currentSum += numArray[j];
                    if (currentSum == sum)
                    {
                        for (int k = currentIndex; k <= j; k++)
                        {
                            if (k < j)
                            {
                                Console.Write("{0}, ", numArray[k]);
                            }
                            else
                            {
                                Console.WriteLine("{0}", numArray[k]);
                            }
                        }
                        break;
                    }
                }
                currentSum = 0;
            }
        }
    }
}
