﻿using System;

//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two 
//variables (mind adding an interval). Declare a third string variable and initialize it with 
//the value of the object variable (you should perform type casting).

namespace _6.TypeCasting
{
    class TypeCasting
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object concatenatedString = hello + " " + world;

            string helloWorld = concatenatedString.ToString();

            Console.WriteLine(helloWorld);
        }
    }
}
