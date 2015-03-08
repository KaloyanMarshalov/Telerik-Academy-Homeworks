using System;

//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

namespace _15.BitExchange
{
    class BitExchange
    {
        static void Main()
        {
            Console.Write("Inset a number: ");
            uint number = uint.Parse(Console.ReadLine());

            uint bitThree = (number & (1 << 3)) >> 3;
            uint bitFour = (number & (1 << 4)) >> 4;
            uint bitFive = (number & (1 << 5)) >> 5;
            uint bitTwentyFour = (number & (1 << 24)) >> 24;
            uint bitTwentyFive = (number & (1 << 25)) >> 25;
            uint bitTwentySix = (number & (1 << 26)) >> 26;
            uint temp;
            uint result;

            temp = bitThree == 0 ? number & ~((uint)(1 << 24)) : number | 1 << 24;
            result = temp;
            temp = bitThree == 0 ? result & ~((uint)(1 << 24)) : result | 1 << 24;
            result = temp;
            temp = bitThree == 0 ? result & ~((uint)(1 << 24)) : result | 1 << 24;
            result = temp;
            temp = bitTwentyFour == 0 ? result & ~((uint)(1 << 3)) : result | 1 << 3;
            result = temp;
            temp = bitTwentyFive == 0 ? result & ~((uint)(1 << 4)) : result | 1 << 4;
            result = temp;
            temp = bitTwentySix == 0 ? result & ~((uint)(1 << 5)) : result | 1 << 5;
            result = temp;


            Console.WriteLine("Old number: {0}. New number: {1}", number, result);
        }
    }
}
