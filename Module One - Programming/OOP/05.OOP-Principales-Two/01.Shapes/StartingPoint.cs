using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>{
                new Square(12.3),
                new Rectangle(10, 3.2),
                new Triangle(2, 3),
                new Rectangle(7, 5.9),
                new Rectangle(10, 3.7),
                new Square(2),
                new Triangle(4, 3),
            };
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
