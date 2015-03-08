using System;

//Write an expression that checks if given positive integer number n (n = 100) is prime 
//(i.e. it is divisible without remainder only to itself and 1).

namespace _8.CheckIfNIntegerIsPrime
{
    class CheckPrime
    {
        static void Main()
        {
            Console.Write("Inser a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (number > 100)
            {
                Console.WriteLine("Invalid input");
            }
            else if (number == 1)
            {
                isPrime = false;
                Console.WriteLine(isPrime);
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine(isPrime);
            }
        }
    }
}
