using System;
using System.Globalization;

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than 
//the second one. As a result print the values a and b, separated by a space.

namespace _1.IntegerValueExchange
{
    class ValueExchange
    {
        static void Main()
        {
            
            Console.Write("Insert double a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Insert double b ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double temp = 0;

            if (a > b)
            {
                temp = b;
                b = a;
                a = temp;
            }
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
