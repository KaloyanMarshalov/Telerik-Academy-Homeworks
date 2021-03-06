﻿using System;
/*
    Problem 5. Sort by string length

    You are given an array of strings. Write a method that sorts the array 
    by the length of its elements (the number of characters composing them).
 
    Examples:
                Input:
        "george", "peter", "aleksandar", "ivan", "konstantin", "velislav"

                Output:
                ivan
                peter
                george
                velislav
                aleksandar
                konstantin
 */
class SortByStringLength
{
    static void Main()
    {
        //string[] strings = { "12", "12345", "123456", "1", "1234", "123" };
        string[] strings = { "george", "peter", "aleksandar", "ivan", "konstantin", "velislav" };
        SortingMethod(strings);
        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
    }
    static void SortingMethod(string[] array)
    {
        int[] stringsLenghts = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            stringsLenghts[i] = array[i].Length;
        }
        Array.Sort(stringsLenghts, array);
        return;
    }
}