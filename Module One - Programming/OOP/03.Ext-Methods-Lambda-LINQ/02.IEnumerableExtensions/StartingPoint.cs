using System;
using System.Collections.Generic;

namespace _02.IEnumerableExtensions
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 56, 1 };
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Average());
        }
    }
}
