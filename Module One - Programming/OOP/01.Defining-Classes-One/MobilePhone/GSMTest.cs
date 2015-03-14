namespace MobilePhone
{
    using System;

    public class GSMTest
    {
        public static void TestGSM()
        {
            var gsmArray = new GSM[] {
                new GSM("Galaxy S5", "Samsung", 1000.50M, "Petur Ivanov",
                                                    new Battery("SamsungBattery", 100, 8, Battery.TypeOfBattery.NuMH),
                                                    new Display(10, 1000000)),
                new GSM("ONE", "HTC", 802.50M, "Ivan Petrov",
                                                    new Battery("HTCBattery", 120, 10, Battery.TypeOfBattery.LiIon),
                                                    new Display(10, 1200000)),
                new GSM("G3", "LG", 1200.50M, "Just Pesho",
                                                    new Battery("LGBattery", 102, 11, Battery.TypeOfBattery.NiCd),
                                                    new Display(11, 3000000))
            };

            foreach (var gsm in gsmArray)
            {
                Console.WriteLine(gsm);
                Console.WriteLine("\n\n");
            }
            Console.WriteLine(GSM.Iphone4S);
        } 
    }
}
