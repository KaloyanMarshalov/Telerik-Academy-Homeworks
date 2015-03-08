using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Number cannot be negative!");
            }
            return Math.Sqrt(number);
        }
        static void Main()
        {
            try
            {

                Console.Write("Insert number: ");
                double number = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                double root = CalculateSquareRoot(number);
                Console.WriteLine(root);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");   
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
