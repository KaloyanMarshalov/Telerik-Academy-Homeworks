using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Calulation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            int sum = 0;
            foreach (var word in words)
            {
                sum += BaseToDecimal(word, 23);
            }

            string baseNum = DecimalToBase(sum, 23);

            Console.WriteLine("{0} = {1}", baseNum, sum);
        }
        static string DecimalToBase(int decimalNum, int systemBase)
        {
            string result = "";
            decimalNum = Math.Abs(decimalNum);
            while (decimalNum > 0)
            {
                int digit = decimalNum % systemBase;
                result = (char)(digit + 'a') + result;

                decimalNum /= systemBase;
            }
            return result;
        }

        static int BaseToDecimal(string baseNumber, int systemBase)
        {
            int decimalNumber = 0;

            for (int i = 0; i < baseNumber.Length; i++)
            {
                int digit = 0;
                digit = baseNumber[i] - 'a';

                decimalNumber += digit * (int)Math.Pow(systemBase, baseNumber.Length - 1 - i);
            }
            return decimalNumber;
        }
    }
}
