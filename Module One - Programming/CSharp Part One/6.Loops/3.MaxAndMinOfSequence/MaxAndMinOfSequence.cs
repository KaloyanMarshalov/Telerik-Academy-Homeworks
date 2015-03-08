using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

namespace _3.MaxAndMinOfSequence
{
    class MaxAndMinOfSequence
    {
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            int maxNum = numberArray[0];
            int minNum = numberArray[0];
            int sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (maxNum < numberArray[i])
                {
                    maxNum = numberArray[i];
                }
                if (minNum > numberArray[i])
                {
                    minNum = numberArray[i];
                }
                sum += numberArray[i];
            }

            double avg = (double)sum / n;

            Console.WriteLine("min = {0}", minNum);
            Console.WriteLine("max = {0}", maxNum);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0}", avg);
        }
    }
}
