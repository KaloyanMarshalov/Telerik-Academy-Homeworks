using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_06.DirectConvertions
{
    class Converter
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>() 
        { 
            {"0", "0000"},
            {"1", "0001"},
            {"2", "0010"},
            {"3", "0011"},
            {"4", "0100"},
            {"5", "0101"},
            {"6", "0110"},
            {"7", "0111"},
            {"8", "1000"},
            {"9", "1001"},
            {"A", "1010"},
            {"B", "1011"},
            {"C", "1100"},
            {"D", "1101"},
            {"E", "1110"},
            {"F", "1111"}
        };

        static string BinaryToHex(string binaryNum)
        {
            while (binaryNum.Length % 4 != 0)
            {
                binaryNum = "0" + binaryNum;
            }

            string result = "";
            for (int i = 0; i < binaryNum.Length; i+=4)
            {
                string currentBinary = binaryNum.Substring(i, 4);
                var digit = dictionary.FirstOrDefault(d => d.Value == currentBinary)
                                      .Key;
                result += digit;
            }
            return result;
        }
        static string HexToBinary(string hexNum)
        {
            string result = "";
            for (int i = 0; i < hexNum.Length; i++)
            {
                string currentHex = hexNum[i].ToString();
                var digit = dictionary.FirstOrDefault(d => d.Key == currentHex)
                                      .Value;
                result += digit;
            }
            return result;
        }
        static void Main()
        {
            Console.Write("Insert hex number: ");
            string hexNum = Console.ReadLine();
            Console.Write("Insert binary number: ");
            string binaryNum = Console.ReadLine();

            string hexToBin = HexToBinary(hexNum);
            string binToHex = BinaryToHex(binaryNum);
            Console.WriteLine("Hex to binary: " + hexToBin);
            Console.WriteLine("Binary to hex: " + binToHex);
        }
    }
}
