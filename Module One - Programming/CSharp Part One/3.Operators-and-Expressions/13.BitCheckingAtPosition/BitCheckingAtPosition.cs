using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

namespace _13.BitCheckingAtPosition
{
    class BitCheckingAtPosition
    {
        static void Main()
        {
            Console.Write("Insert number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Insert position: ");
            int p = int.Parse(Console.ReadLine());

            if ((n >> p) == 1)
            {
                Console.WriteLine("The bit at position {0} in the number {1} is 1", p, n);
            }
            else
            {
                Console.WriteLine("The bit at position {0} in the number {1} is 0", p, n);
            }
        }
    }
}
