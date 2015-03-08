using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

namespace _13.SolveTasks
{
    class Solve
    {
        static int ReverseNumber(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result = result * 10 + number % 10;
                number /= 10;
            }
            return result;
        }
        static double CalculateAvarage(int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            double avarage = result / numbers.Length;
            return avarage;
        }
        static double SolveEquation(int a, int b)
        {
            double x = (double)b / (double)a * -1;
            return x;
        }
        static void Main()
        {
            Console.WriteLine("Which task do you wanto to solve?");
            Console.Write("Insert 1 for Reverse, 2 for Avarage or 3 to Solve Equation: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Clear();
                Console.WriteLine("Reverse number");
                Console.Write("Insert number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    Console.WriteLine("Error! Number cannot be negative");
                }
                else
                {
                    number = ReverseNumber(number);
                    Console.WriteLine(number);
                }
            }
            else if (option == 2)
            {
                Console.Clear();
                Console.WriteLine("Avarage number");
                Console.WriteLine("Insert the length of the array: ");
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine("Error! The array cannot be empty");
                }
                else
                {
                    Console.WriteLine("Insert the elements of the array");
                    int[] numArray = new int[n];
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        numArray[i] = int.Parse(Console.ReadLine());
                    }
                    double avarageNum = CalculateAvarage(numArray);
                    Console.WriteLine(avarageNum);
                }
            }
            else if (option == 3)
            {
                Console.Clear();
                Console.WriteLine("Equation");
                Console.Write("Insert a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Insert b: ");
                int b = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Error! A cannot be zero");
                }
                else
                {
                    double result = SolveEquation(a, b);
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Error! Inserr 1, 2 or 3");
            }
        }
    }
}
