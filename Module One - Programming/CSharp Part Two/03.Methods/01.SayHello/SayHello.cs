using System;

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

namespace _01.SayHello
{
    class SayHello
    {
        static void SayName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            Console.Write("Your name is: ");
            string input = Console.ReadLine();
            SayName(input);
        }
    }
}
