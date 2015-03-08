using System;

//Write a program that reads two integer arrays from the console and compares them element by element.

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            //Arrays have the same length
            Console.Write("Insert length of the arrays: ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            Console.WriteLine("Insert elements for the first array");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Insert elements for the second array");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} == {1}", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.WriteLine("{0} != {1}", firstArray[i], secondArray[i]);
                }
            }

            /*
             * //Arrays have different lenghts
             *
            Console.Write("Insert length of array one: ");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            Console.Write("Insert length of array two: ");
            int m = int.Parse(Console.ReadLine());
            int[] secondArray = new int[m];
            Console.WriteLine("Insert elements for the first array");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Insert elements for the second array");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        Console.WriteLine("{0} == {1}", firstArray[i], secondArray[i]);
                    }
                    else
                    {
                        Console.WriteLine("{0} != {1}", firstArray[i], secondArray[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("The arrays have different lengths");
                Console.WriteLine("Length of array one: {0}", firstArray.Length);
                Console.WriteLine("Length of array two: {0}", secondArray.Length);
            }    
            */
        }
    }
}
