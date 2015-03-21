namespace CoordinateSystem
{
    using System.Collections.Generic;
    class Path
    {
        List<Point3D> pointsSequence = new List<Point3D>();
        public Path(List<Point3D> pathSequence)
        {
            this.PointsSequence = pathSequence;
        }
        public Path()
        {
        }

        public List<Point3D> PointsSequence
        {
            get { return this.pointsSequence; }
            set { this.pointsSequence = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.pointsSequence.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.pointsSequence.Remove(point);
        }
    }
}
