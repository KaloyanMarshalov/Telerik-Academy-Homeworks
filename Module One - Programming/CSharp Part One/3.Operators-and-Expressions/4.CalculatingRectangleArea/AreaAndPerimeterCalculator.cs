using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace _4.CalculatingRectangleArea
{
    class AreaAndPerimeterCalculator
    {
        static void Main()
        {
            Console.Write("Insert width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Insert height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is {0}", width * height);
            Console.WriteLine("The rectangle's perimeter is {0}", 2 * width + 2 * height);
        }
    }
}
