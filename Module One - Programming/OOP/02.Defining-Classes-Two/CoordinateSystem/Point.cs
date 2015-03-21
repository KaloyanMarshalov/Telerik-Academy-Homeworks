namespace CoordinateSystem
{
    using System.Text;

    struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0, 0, 0);
        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public static Point3D PointO 
        { 
            get { return pointO; } 
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{");
            result.AppendFormat("{0}, {1}, {2}", this.X, this.Y, this.Z);
            result.Append("}");
            return result.ToString();
        }
    }
}
