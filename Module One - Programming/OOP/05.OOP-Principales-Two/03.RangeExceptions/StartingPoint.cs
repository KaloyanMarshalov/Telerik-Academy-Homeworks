using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RangeExceptions
{
    class StartingPoint
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input!", 2, 50);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new string('-', 40));

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1981, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
