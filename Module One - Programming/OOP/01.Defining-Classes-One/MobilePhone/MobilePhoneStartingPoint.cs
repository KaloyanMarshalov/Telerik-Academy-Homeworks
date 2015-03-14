using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class MobilePhoneStartingPoint
    {
        static void Main()
        {
            string equalsSignString = new string('=', 20);
            Console.WriteLine("\n{0} Testing the GSM Class {0}\n", equalsSignString);
            GSMTest.TestGSM();


            Console.WriteLine("\n{0} Testing the Call Class {0}\n", equalsSignString);
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}
