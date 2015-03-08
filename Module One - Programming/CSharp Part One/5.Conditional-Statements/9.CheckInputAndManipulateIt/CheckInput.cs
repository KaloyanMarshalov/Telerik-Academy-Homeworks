using System;
using System.Globalization;

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

namespace _9.CheckInputAndManipulateIt
{
    class CheckInput
    {
        static void Main()
        {
            Console.WriteLine("Insert 1 for string, 2 for int or 3 for double");
            int type = int.Parse(Console.ReadLine());
            Console.Write("Insert input: ");

            switch (type)
            {
                case 1:
                    string stringInput = Console.ReadLine() + "*";
                    Console.WriteLine(stringInput);
                    break;
                case 2:
                    int intInput = int.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(intInput);
                    break;
                case 3:
                    double doubleInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) + 1;
                    Console.WriteLine(doubleInput);
                    break;
                default:
                    break;
            }
        }
    }
}
