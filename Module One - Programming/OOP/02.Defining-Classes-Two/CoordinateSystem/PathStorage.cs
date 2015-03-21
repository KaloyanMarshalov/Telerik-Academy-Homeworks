namespace CoordinateSystem
{
    using System.IO;
    static class PathStorage
    {
        public static void SavePath(Path path, string pathName) 
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathName + ".txt"))
            {
                for (int i = 0; i < path.PointsSequence.Count; i++)
                {
                    sw.WriteLine(path.PointsSequence[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point3D nextPoint = ParsePoint(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }
        private static Point3D ParsePoint(string point)
        {
            int endIndex = 0;
            int startIndex = 1;
            double[] xyz = new double[3];
            int counter = 0;
            while (true)
            {
                endIndex = point.IndexOf(',', startIndex);
                if (endIndex < 0)
                {
                    xyz[counter] = double.Parse(point.Substring(startIndex, point.Length - startIndex - 1));
                    break;
                }
                xyz[counter] = double.Parse(point.Substring(startIndex, endIndex - startIndex));
                startIndex = endIndex + 1;
                counter++;
            }

            Point3D pointResult = new Point3D() { X = xyz[0], Y = xyz[1], Z = xyz[2]};
            return pointResult;
        }
    }
}
