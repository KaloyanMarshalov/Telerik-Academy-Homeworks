namespace _01.Shapes
{
    public abstract class Shape
    {
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract double CalculateSurface();
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
    }
}
