using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

namespace _6.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Insert a four-digit number: ");
            string number = Console.ReadLine();

            if (number.Length != 4 || number[0] == 0)
            {
                Console.WriteLine("Invalid input. The number must have 4 digits and cannot start with 0");
            }

            int digitsSum = 0;
            int reversedNumber = 0;
            int lastAndFirst = 0;
            int secondAndThird = 0;

            for (int i = 0; i < number.Length; i++)
            {
                digitsSum += int.Parse(number[i].ToString());
            }

            char[] arr = number.ToCharArray();
            Array.Reverse(arr);
            reversedNumber = int.Parse(new string(arr));

            lastAndFirst = int.Parse(number[3].ToString() + number[1].ToString() + number[2].ToString() + number[0].ToString());
            secondAndThird = int.Parse(number[0].ToString() + number[2].ToString() + number[1].ToString() + number[3].ToString());

            Console.WriteLine("Sum of digits: {0}", digitsSum);
            Console.WriteLine("Reversed number: {0}", reversedNumber);
            Console.WriteLine("Last and first bit exchanged: {0}", lastAndFirst);
            Console.WriteLine("Second and thrid bit exchanged: {0}", secondAndThird);
        }
    }
}
