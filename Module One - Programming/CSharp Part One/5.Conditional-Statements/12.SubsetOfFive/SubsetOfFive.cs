using System;

//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.

namespace _12.SubsetOfFive
{
    class SubsetOfFive
    {
        static void Main()
        {
            Console.WriteLine("Insert five integers:");
            int[] numberArray = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == 0)
                {
                    Console.WriteLine("{0} = 0", numberArray[i]);
                    break;
                }
            }
            for (int i = 0; i < numberArray.Length - 2; i++)
            {
                for (int j = i + 1; j < numberArray.Length; j++)
                {
                    if (numberArray[i] + numberArray[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numberArray[i], numberArray[j]);
                        break;
                    }
                    for (int k = j + 1; k < numberArray.Length; k++)
                    {
                        if (numberArray[i] + numberArray[j] + numberArray[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numberArray[i], numberArray[j], numberArray[k]);
                            break;
                        }
                        for (int l = k + 1; l < numberArray.Length; l++)
                        {
                            if (numberArray[i] + numberArray[j] + numberArray[k] + numberArray[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numberArray[i], numberArray[j], numberArray[k], numberArray[l]);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
