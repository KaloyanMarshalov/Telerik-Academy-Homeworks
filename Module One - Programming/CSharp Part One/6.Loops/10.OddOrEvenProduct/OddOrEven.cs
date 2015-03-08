using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace _10.OddOrEvenProduct
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            int[] numArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                numArr[i] = int.Parse(Console.ReadLine());
            }
            int oddProduct = 1;
            int evenProduct = 1;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= numArr[i];
                }
                else
                {
                    evenProduct *= numArr[i];
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddProduct);
                Console.WriteLine("even_product = {0}", evenProduct);
            }
        }
    }
}
