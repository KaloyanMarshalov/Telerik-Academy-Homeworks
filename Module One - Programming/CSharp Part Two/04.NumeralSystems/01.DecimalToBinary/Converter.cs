using System;

namespace _01.DecimalToBinary
{
    class Converter
    {
        static string DecimalToBase(int decimalNum, int systemBase)
        {
            string result = "";
            bool isNegative = decimalNum < 0 ? true : false;

            decimalNum = Math.Abs(decimalNum);
            while (decimalNum > 0)
            {
                int digit = decimalNum % systemBase;
                if (digit >= 0 && digit <= 9)
                {
                    result = (char)(digit + '0') + result;
                }
                else
                {
                    result = (char)(digit - 10 + 'A') + result;
                }
                decimalNum /= systemBase;
            }
            if (isNegative)
            {
                return "-" + result;
            }
            return result;
        }

        static int BaseToDecimal(string baseNumber, int systemBase)
        {
            int decimalNumber = 0;
            bool isNegative = baseNumber[0] == '-' ? true : false;

            for (int i = isNegative ? 1 : 0; i < baseNumber.Length; i++)
            {
                int digit = 0;
                if (baseNumber[i] >= '0' && baseNumber[i] <= '9')
                {
                    digit = baseNumber[i] - '0';
                }
                else
                {
                    digit = baseNumber[i] - 'A' + 10;
                }
                decimalNumber += digit * (int)Math.Pow(systemBase, baseNumber.Length - 1 - i);
            }

            if (isNegative)
            {
                return -decimalNumber;
            }
            return decimalNumber;
        }
        static void Main()
        {
            Random rand = new Random();
            int number = rand.Next(int.MinValue, int.MaxValue);
            Console.WriteLine("Random number: " + number);
            //01 - Decimal to binary
            string binaryNum = DecimalToBase(number, 2);
            Console.WriteLine("Binary representation: " + binaryNum);

            //02 - Binary to decimal
            int decimalNum = BaseToDecimal(binaryNum, 2);
            Console.WriteLine("Back to decimal: " + decimalNum);

            //03 - Decimal to hexadecimal
            string hexNumber = DecimalToBase(number, 16);
            Console.WriteLine("Hexadecimal representation: " + hexNumber);

            //04 - Hexadecimal to decimal
            decimalNum = BaseToDecimal(hexNumber, 16);
            Console.WriteLine("Back to decimal: " + decimalNum);

            //07 - One system to any other
            int randomBase1 = rand.Next(2, 16);
            int randomBase2 = rand.Next(2, 16);

            //Gets a random number and convert it to its base, can be hardcoded or read from the console 
            string toBase1 = DecimalToBase(number, randomBase1);
            string result = DecimalToBase(BaseToDecimal(toBase1, randomBase1), randomBase2);
            Console.WriteLine("From {0}, to {1} = {2}", randomBase1, randomBase2, result);
        }
    }
}
