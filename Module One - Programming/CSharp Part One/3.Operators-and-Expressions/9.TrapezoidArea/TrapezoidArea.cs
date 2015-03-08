using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace _9.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("Insert side a, than side b, than height h");
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int heightH = int.Parse(Console.ReadLine());
            int area = (sideA + sideB) * heightH / 2;
            Console.WriteLine(area);
        }
    }
}
