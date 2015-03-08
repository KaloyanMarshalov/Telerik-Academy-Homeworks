using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static int CountAppearances (int[] numArray, int searchedNumber)
        {
            int count = 0;
            foreach (int number in numArray)
            {
                if (number == searchedNumber)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            
            int[] numArray = new int[n];
            Console.WriteLine("Insert the elements of the array");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Insert the number: ");
            int number = int.Parse(Console.ReadLine());

            int appearances = CountAppearances(numArray, number);
            Console.WriteLine(appearances);
        }
    }
}
