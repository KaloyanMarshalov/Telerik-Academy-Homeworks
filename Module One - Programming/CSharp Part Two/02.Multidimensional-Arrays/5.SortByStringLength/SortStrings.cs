using System;
//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

namespace _5.SortByStringLength
{
    class SortStrings
    {
        static void SortStringArray(string[] stringArray)
        {
            string temp;
            int minIndex;
            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[j].Length < stringArray[minIndex].Length)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    temp = stringArray[i];
                    stringArray[i] = stringArray[minIndex];
                    stringArray[minIndex] = temp;
                }
            }
        }
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());

            string[] stringArray = new string[n];
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
            SortStringArray(stringArray);

            foreach (string item in stringArray)
            {
                Console.Write("{0} ", item);
            }       
        }
    }
}
