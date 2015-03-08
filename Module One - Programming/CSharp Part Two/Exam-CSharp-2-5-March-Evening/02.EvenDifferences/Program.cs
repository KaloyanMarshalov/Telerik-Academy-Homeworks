using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.EvenDifferences
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] inputNums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            BigInteger absoluteDifferencesSum = 0;
            long absoluteDifference = 0;
            for (int i = 1; i < inputNums.Length; i += 0)
            {
                absoluteDifference = Math.Abs(inputNums[i] - inputNums[i - 1]);
                if (absoluteDifference % 2 == 0)
                {
                    absoluteDifferencesSum += absoluteDifference;
                    i += 2;
                }
                else
                {
                    i += 1;
                }
            }
            Console.WriteLine(absoluteDifferencesSum);
        }
    }
}
