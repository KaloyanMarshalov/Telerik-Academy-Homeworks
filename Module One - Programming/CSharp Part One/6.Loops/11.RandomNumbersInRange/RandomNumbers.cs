using System;

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

namespace _11.RandomNumbersInRange
{
    class RandomNumbers
    {
        static void Main()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Insert max: ");
            int max = int.Parse(Console.ReadLine());

            Random randomInstance = new Random();
            int randomInt = 0;

            for (int i = 0; i < n; i++)
            {
                randomInt = randomInstance.Next(min, max + 1);
                Console.WriteLine(randomInt);
            }
        }
    }
}
