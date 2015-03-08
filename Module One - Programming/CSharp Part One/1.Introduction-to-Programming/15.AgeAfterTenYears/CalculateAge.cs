using System;

// Write a program to read your age from the console and print how old you will be after 10 years.

namespace AgeAfterTenYears
{
    class CalculateAge
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("After ten years you will be {0}!", age + 10);
        }
    }
}
