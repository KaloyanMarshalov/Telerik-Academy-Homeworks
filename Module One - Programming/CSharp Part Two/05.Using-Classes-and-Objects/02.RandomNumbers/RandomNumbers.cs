﻿using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                //the minValue is inclusive, while the maxValue is exclusive
                Console.WriteLine(rand.Next(100, 201));
            }
        }
    }
}
