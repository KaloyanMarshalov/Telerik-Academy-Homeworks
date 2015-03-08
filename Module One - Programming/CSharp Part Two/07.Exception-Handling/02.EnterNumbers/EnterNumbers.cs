using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static int ReadNumber(int start, int end)
        {
            Console.Write("Enter number: ");
            int input = int.Parse(Console.ReadLine());

            if (input < start || input > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return input;
        }
        static void Main()
        {
            int[] numbers = new int[10];
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = ReadNumber(1, 100);
                }
            }
            catch (ArgumentOutOfRangeException aor)
            {
                throw aor;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
