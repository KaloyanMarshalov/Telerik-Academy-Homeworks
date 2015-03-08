using System;

//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

namespace _4.GreaterNumber
{
    class GreaterNumber
    {
        static void Main()
        {
            Console.Write("Insert number1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Insert number2: ");
            int num2 = int.Parse(Console.ReadLine());

            int greaterNum = num1 > num2 ? num1 : num2;
            Console.WriteLine(greaterNum);
        }
    }
}
