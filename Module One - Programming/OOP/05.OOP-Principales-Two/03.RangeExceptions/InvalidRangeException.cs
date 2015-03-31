namespace _03.RangeExceptions
{
    using System;
    public class InvalidRangeException<T> : ApplicationException
    {
        const string format = "{0}\nParameter should be in range[{1}; {2}]";
        public InvalidRangeException(string message, T start, T end, Exception exception)
            : base(String.Format(format, message, start, end), exception)
        {
            this.Start = start;
            this.End = end;
        }
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) { }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) { }

        public T Start { get; set; }
        public T End { get; set; }
    }
}
