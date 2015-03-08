using System;
using System.Collections.Generic;
using System.Linq;

//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Insert first number: ");
        string num1 = Console.ReadLine();

        Console.Write("Insert second number: ");
        string num2 = Console.ReadLine();


        List<int> result = ConcatenateNumbers(num1, num2);
        Console.WriteLine("Result: ");
        PrintResult(result);
    }


    static List<int> ConcatenateNumbers(string num1, string num2)
    {
        var firstNum = num1.Select(ch => ch - '0')
                            .Reverse()
                            .ToArray();
        var secondNum = num2.Select(ch => ch - '0')
                            .Reverse()
                            .ToArray();


        List<int> result = new List<int>(Math.Max(firstNum.Length, secondNum.Length));

        int left = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < firstNum.Length ? firstNum[i] : 0) + (i < secondNum.Length ? secondNum[i] : 0) + left;
            left = num / 10;
            result.Add(num % 10);
        }

        if (left > 0)
        {
            result.Add(left);
        }
        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
