using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace _13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Insert binary number: ");
            string binaryNum = Console.ReadLine();
            long decimalNum = 0;
            for (int i = 0; i < binaryNum.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (binaryNum[binaryNum.Length - i - 1] == '0') continue;
                decimalNum += (int)Math.Pow(2, i);
            }
            Console.WriteLine(decimalNum);
        }
    }
}
