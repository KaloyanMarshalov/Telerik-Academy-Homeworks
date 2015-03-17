using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(12, 2, 10);
            Console.WriteLine(point);
            Console.WriteLine(Point3D.PointO);
        }
    }
}
