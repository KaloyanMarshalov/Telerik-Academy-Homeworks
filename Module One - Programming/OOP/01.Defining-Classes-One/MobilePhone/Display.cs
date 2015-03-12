namespace MobilePhone
{
    using System;

    //size and number of colors

    public class Display
    {
        private int size;
        private int numOfColors;

        public Display()
        {
        }
        public Display(int size, int numOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numOfColors;
        }
        public int Size
        {
            get { return this.size; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The size of the display cannot be less or equal than zero");
                }
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get { return this.numOfColors; }
            set {
                if (value <= 0)
                {
                    throw new ArgumentException("The ammount of colors cannot be less than or equal to zero");
                }
                this.numOfColors = value; }
        }
    }
}
