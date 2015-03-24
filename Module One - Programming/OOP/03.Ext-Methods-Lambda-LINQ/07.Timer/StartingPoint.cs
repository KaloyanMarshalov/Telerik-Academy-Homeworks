using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Timer
{
    class StartingPoint
    {
        static void Main()
        {
            Timer timer = new Timer(2);

            timer.Methods += FirstTestMethod;
            timer.Methods += SecondTestMethod;

            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.WriteLine("First");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("Second");
        }
    }
}
