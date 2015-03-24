
namespace _07.Timer
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void TimerDelegate();

        public Timer(int time)
        {
            this.Interval = time;
        }
        public int Interval { get; set; }
        public TimerDelegate Methods { get; set; }
        public void ExecuteMethods()
        {
            while (true)
            {
                this.Methods();
                Thread.Sleep(this.Interval * 1000);   
            }
        }
    }
}
