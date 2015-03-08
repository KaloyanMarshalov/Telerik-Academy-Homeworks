using System;

//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 1.5) and out of 
//the rectangle R(top=1, left=-1, width=6, height=2).

namespace _10.PointInsideCircleAndOutOfRectangle
{
    class PointInsideCircleOutRectangle
    {
        static void Main()
        {
            Console.Write("Insert x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Insert y: ");
            double y = double.Parse(Console.ReadLine());

            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1) < 2.25 ? true : false);
            bool outRectangle = ((x > -1 && x < 5) && (y > -1 && y < 1) ? false : true);

            Console.WriteLine("The point ({0}, {1}) is:", x, y);
            Console.WriteLine("Inside the circle: {0}", inCircle);
            Console.WriteLine("Outside the rectangle: {0}", outRectangle);
        }
    }
}
