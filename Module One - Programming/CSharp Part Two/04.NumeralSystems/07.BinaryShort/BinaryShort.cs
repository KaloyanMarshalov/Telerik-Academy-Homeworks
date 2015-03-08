using System;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _07.BinaryShort
{
    class BinaryShort
    {
        static string ShortToBinary(short number)
        {
            string binaryShort = DecimalToBase(number, 2);
            while (binaryShort.Length % 16 != 0)
            {
                binaryShort = "0" + binaryShort;
            }
            return binaryShort;
        }
        static string DecimalToBase(int decimalNum, int systemBase)
        {
            string result = "";
            bool isNegative = decimalNum < 0 ? true : false;

            decimalNum = Math.Abs(decimalNum);
            while (decimalNum > 0)
            {
                int digit = decimalNum % systemBase;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decimalNum /= systemBase;
            }
            if (isNegative)
            {
                return "-" + result;
            }
            return result;
        }
        static void Main()
        {
            Console.WriteLine("Insert short integer: ");
            short number = short.Parse(Console.ReadLine());

            string binaryShort = ShortToBinary(number);
            Console.WriteLine(binaryShort);
        }
    }
}
