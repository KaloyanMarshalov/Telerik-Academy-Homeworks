using System;
using System.Linq;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace _14.IntegerCalculations
{
    class IntCalculations
    {
        static int Minimum(int[] numArray)
        {
            int min = numArray.Min();
            return min;
        }
        static int Maximum(int[] numArray)
        {
            int max = numArray.Max();
            return max;
        }
        static double Avarage(int[] numArray)
        {
            double avarage = numArray.Average();
            return avarage;
        }
        static int Sum(int[] numArray)
        {
            int sum = numArray.Sum();
            return sum;
        }
        static int Product(int[] numArray)
        {
            int product = 1;
            foreach (int number in numArray)
            {
                product *= number;
            }
            return product;
        }
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                numArray[i] = int.Parse(Console.ReadLine());
            }

            int min = Minimum(numArray);
            int max = Maximum(numArray);
            double avarage = Avarage(numArray);
            int sum = Sum(numArray);
            int product = Product(numArray);

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Avarage: " + avarage);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
    }
}
