using System;

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

namespace _3.HexInteger
{
    class HexInteger
    {
        static void Main()
        {
            int hexNumber = Convert.ToInt32("FE", 16);
            Console.WriteLine(hexNumber);
        }
    }
}
