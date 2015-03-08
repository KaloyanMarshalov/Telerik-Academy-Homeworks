using System;
using System.Globalization;
using System.Threading;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.Write("Insert 1 for Side and height, 2 for three sides or 3 for two sides and an angle between them: ");
            int choice = int.Parse(Console.ReadLine());

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            if (choice == 1)
            {
                Console.Write("Insert the side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Insert height: ");
                double height = double.Parse(Console.ReadLine());

                double area = side * height / 2;
                Console.WriteLine(area);
            }
            else if (choice == 2)
            {
                Console.Write("Insert side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Insert side 2: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Insert side 3: ");
                double side3 = double.Parse(Console.ReadLine());

                double area = side1 + side2 + side3;
                Console.WriteLine(area);
            }
            else
            {
                Console.Write("Insert side 1: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.Write("Insert side 2: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.Write("Insert angle: ");
                double angle = double.Parse(Console.ReadLine());

                double area = side1 * side2 / 2 * Math.Sin(angle);
                Console.WriteLine(area);
            }
        }
    }
}
