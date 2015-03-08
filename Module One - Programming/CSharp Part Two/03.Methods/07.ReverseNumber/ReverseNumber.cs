using System;
using System.Linq;

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static string ReverseNum(string number)
        {
            return new string(number
                              .ToCharArray()
                              .Reverse()
                              .ToArray());
        }
        static void Main()
        {
            Console.Write("Insert number: ");
            string number = Console.ReadLine();

            Console.WriteLine(ReverseNum(number));
        }
    }
}
