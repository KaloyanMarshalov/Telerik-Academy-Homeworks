using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateSystem
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(12, 2, 10);
            Point3D secondPoint = new Point3D(10, 2, 3);
            //Console.WriteLine(DistanceCalculator.DistanceBetweenTwo(point, secondPoint));
            //Console.WriteLine(point);
            //Console.WriteLine(Point3D.PointO);
            var path = new Path(new List<Point3D> { point, secondPoint });
            PathStorage.SavePath(path, "FirstPath");
            Path loadedPath = PathStorage.LoadPath(@"../../pathFirstPath.txt");
            foreach (var path2 in loadedPath.PointsSequence)
            {
                Console.WriteLine(path2);
            }
        }
    }
}
