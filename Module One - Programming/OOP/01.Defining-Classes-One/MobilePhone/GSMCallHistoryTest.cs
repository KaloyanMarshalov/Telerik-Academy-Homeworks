namespace MobilePhone
{
    using System;
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM phone = new GSM("Desire", "HTC", 800.23M, "Geogri Petrov",
                                new Battery("HTCBattery", 123, 12, Battery.TypeOfBattery.NuMH),
                                new Display(12, 123456789));
            DateTime today = DateTime.Now;
            DateTime hours = new DateTime();
            phone.AddCall(new Call(today, hours.AddHours(2).AddMinutes(43), "+359878123456", 230));
            phone.AddCall(new Call(today, hours.AddHours(2).AddMinutes(50), "+359878112486", 100));
            phone.AddCall(new Call(today, hours.AddMinutes(10), "+359878111222", 500));
            phone.AddCall(new Call("+359888123123", 1012));

            Call longestCall = phone.CallHistory[0];

            foreach (var call in phone.CallHistory)
            {
                DisplayCall(call);
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }

            Console.WriteLine("Price of all the calls: {0:C}",phone.CallculateCallBill(0.37M));

            phone.DeleteCall(longestCall);
            Console.WriteLine("Price of the calls without the longest one: {0:C}", phone.CallculateCallBill(0.37M));

            phone.ClearCallHistory();
            Console.WriteLine("Length of call history: " + phone.CallHistory.Count);
        }
        private static void DisplayCall(Call call)
        {
            Console.WriteLine("Call Information:\n Date: {0}\n Time: {1}\n PhoneNumber: {2}\n Seconds: {3}",
                              call.Date.ToShortDateString(), call.Time.ToShortTimeString(), call.DialledPhone, call.Duration);
            Console.WriteLine();
        }
    }
}
