using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

namespace _7.PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            Console.Write("Insert x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Insert y: ");
            int y = int.Parse(Console.ReadLine());

            if (x * x + y * y <= 4)
            {
                Console.WriteLine("The point ({0}, {1}) is within the circle", x, y);
            }
            else
            {
                Console.WriteLine("The point ({0}, {1}) is outside the circle", x, y);
            }
        }
    }
}
