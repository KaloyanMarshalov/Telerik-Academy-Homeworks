﻿using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

namespace _01.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int[] numArray = new int[20];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = i * 5;
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
