using System;
using System.Linq;

namespace _06.DivisibleBy7And3
{
    class Divisible
    {
        static void Main()
        {
            var numArray = new[] { 1, 2, 3, 4, 12, 17, 12, 13, 21, 2, 7, 21, 3, 42};
            var result = numArray.Where(n => n % 3 == 0 && n % 7 == 0);
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(new string('=', 20));
            result =
                from number in numArray
                where number % 3 == 0 && number % 7 == 0
                select number;
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}
