using System;

public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Width 
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException();
            }

            this.height = value;
        }
    }

    public Size GetRotatedSize(Size sizeToRotate, double angleOfFigure)
    {
        var absoluteSin = this.GetAbsoluteSin(angleOfFigure);
        var absoluteCos = this.GetAbsoluteCos(angleOfFigure);
        var rotateWidth = sizeToRotate.Width;
        var rotateHeight = sizeToRotate.Height;

        var rotatedSizeWidth = (absoluteCos * rotateWidth) + (absoluteSin * rotateHeight);
        var rotatedSizeHeight = (absoluteSin * rotateWidth) + (absoluteCos * rotateHeight);

        Size rotatedSize = new Size(rotatedSizeWidth, rotatedSizeHeight);

        return rotatedSize;
    }

    private double GetAbsoluteSin(double angle) 
    {
        var sin = Math.Sin(angle);
        var absoluteSin = Math.Abs(sin);

        return absoluteSin;
    }

    private double GetAbsoluteCos(double angle)
    {
        var cos = Math.Cos(angle);
        var absoluteCos = Math.Abs(cos);

        return absoluteCos;
    }
}