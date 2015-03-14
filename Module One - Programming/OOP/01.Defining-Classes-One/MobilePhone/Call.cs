namespace MobilePhone
{
    using System;
    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialledPhone;
        private int durationInSeconds;

        public Call(DateTime date, DateTime time, string dialledPhone, int duration)
        {
            this.Date = date;
            this.Time = time;
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }
        public Call(string dialledPhone, int duration)
        {
            this.Date = DateTime.Now.Date;
            this.Time = DateTime.Now;
            this.DialledPhone = dialledPhone;
            this.Duration = duration;
        }

        public DateTime Date 
        {
            get { return this.date; }
            set { this.date = value; } 
        }
        public DateTime Time
        {
            get { return this.time; }
            set { this.time = value; }
        }
        public string DialledPhone
        {
            get { return this.dialledPhone; }
            set { this.dialledPhone = value; }
        }
        public int Duration
        {
            get { return this.durationInSeconds; }
            set { this.durationInSeconds = value; }
        }
    }
}
