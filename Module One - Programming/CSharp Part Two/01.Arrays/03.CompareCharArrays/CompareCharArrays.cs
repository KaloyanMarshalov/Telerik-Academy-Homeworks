using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            /*
             * //Arrays have the same length
             * 
            Console.Write("Insert length of the arrays: ");
            int n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            char[] secondArray = new char[n];

            Console.WriteLine("Insert the elements of the first array ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert the elements of the second array ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
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
            */
            //Arrays have different lengths
            Console.Write("Insert length of the first array: ");
            int n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            Console.Write("Insert length of the second array: ");
            int m = int.Parse(Console.ReadLine());
            char[] secondArray = new char[m];

            Console.WriteLine("Insert the elements of the first array ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Insert the elements of the second array ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
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
            
        }
    }
}
