using System;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

namespace _4.SignOfThreeNumbers
{
    class SignOfThreeNumbers
    {
        static void Main()
        {
            Console.WriteLine("Insert three numbers");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            bool positiveProduct = true;
            if (num1 < 0 && num2 > 0 && num3 > 0)
            {
                positiveProduct = false;
            }
            else if (num1 > 0 && num2 < 0 && num3 > 0)
            {
                positiveProduct = false;
            }
            else if (num1 > 0 && num2 > 0 && num3 < 0)
            {
                positiveProduct = false;
            }
            else if (num1 < 0 && num2 < 0 && num3 < 0)
            {
                positiveProduct = false;
            }
            Console.WriteLine("Is the sign of the product positive?: {0}", positiveProduct);
        }
    }
}
