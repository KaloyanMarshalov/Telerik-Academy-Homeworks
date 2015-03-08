using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Insert radius r: ");
            int r = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Perimeter: {0:0.00}", perimeter);
            Console.WriteLine("Area: {0:0.00}", area);
        }
    }
}
