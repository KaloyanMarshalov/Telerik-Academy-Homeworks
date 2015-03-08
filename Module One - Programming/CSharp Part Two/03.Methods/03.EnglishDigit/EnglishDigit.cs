using System;

//Write a method that returns the last digit of given integer as an English word.

namespace _03.EnglishDigit
{
    class EnglishDigit
    {
        static string LastDigitName(int number)
        {
            int lastDigit = number % 10;
            string digitName = "";

            switch (lastDigit)
            {
                case 0: digitName = "zero"; 
                    break;
                case 1: digitName = "one";
                    break;
                case 2: digitName = "two";
                    break;
                case 3: digitName = "three";
                    break;
                case 4: digitName = "four";
                    break;
                case 5: digitName = "five";
                    break;
                case 6: digitName = "six";
                    break;
                case 7: digitName = "seven";
                    break;
                case 8: digitName = "eight";
                    break;
                case 9: digitName = "nine";
                    break;
            }
            return digitName;
        }
        static void Main()
        {
            Console.Write("Insert an integer: ");
            int number = int.Parse(Console.ReadLine());

            string lastDigitName = LastDigitName(number);
            Console.WriteLine(lastDigitName);
        }
    }
}
