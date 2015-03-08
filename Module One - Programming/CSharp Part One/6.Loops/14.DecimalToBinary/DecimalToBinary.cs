using System;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace _14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Insert decimal number: ");
            long decimalNum = long.Parse(Console.ReadLine());

            long remainder;
            string binaryNum = "";
            while (decimalNum > 0)
            {
                remainder = decimalNum % 2;
                decimalNum /= 2;
                binaryNum = remainder.ToString() + binaryNum;
            }
            Console.WriteLine("Binary number: {0}", binaryNum);
        }
    }
}
