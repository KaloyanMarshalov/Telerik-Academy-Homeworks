using System;

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02.GetLargestNumber
{
    class LargestNum
    {
        static int GetMax(int num1, int num2)
        {
            int max = num1;
            if (num2 > num1)
            {
                max = num2;
            }
            return max;
        }
        static void Main()
        {
            Console.WriteLine("Insert number 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            int maxInteger = GetMax(num1, GetMax(num2, num3));
            Console.WriteLine(maxInteger);
        }
    }
}
