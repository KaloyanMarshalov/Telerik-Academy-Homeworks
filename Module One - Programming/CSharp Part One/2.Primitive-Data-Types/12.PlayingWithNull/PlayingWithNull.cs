using System;

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

namespace _12.PlayingWithNull
{
    class PlayingWithNull
    {
        static void Main()
        {
            int? nullableInt = null;
            double? nullableDouble = null;
            Console.WriteLine("Int: {0}   Double: {1}", nullableInt, nullableDouble);

            nullableInt += 1;
            nullableDouble += 0.5;
            Console.WriteLine("Int: {0}   Double: {1}", nullableInt, nullableDouble);
        }
    }
}
