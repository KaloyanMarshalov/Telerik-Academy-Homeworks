namespace MobilePhone
{
    //Define a class that holds information about a mobile phone device: model,
    //manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
    //and display characteristics (size and number of colors).
    //Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

    //Define several constructors for the defined classes that take different sets of arguments 
    //(the full information for the class or part of it).
    //Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class GSM
    {
        private string model;
        private string manufacturer;
        private Decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iphone = new GSM("iPhone 4S", "Apple", 1300.50M, "Petur Petrov",
                                                    new Battery("AppleBattery", 240, 8, Battery.TypeOfBattery.LiIon),
                                                    new Display(7, 1000000));
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, Decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public Decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        public static GSM Iphone4S
        {
            get { return iphone; }
        }
        public List<Call> CallHistory 
        {
            get { return this.callHistory; }
            private set { this.callHistory = value; } 
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Phone Information: \n Model: {0}\n Manufacturer: {1}\n Price: {2}\n Owner: {3}\n", 
                                this.Model, this.Manufacturer, this.Price, this.Owner);
            result.AppendLine(new string('-', 20));
            result.AppendFormat("Battery Information:\n Model: {0}\n Type: {1}\n Hours Idle: {2}\n Hours Talk: {3}\n",
                                this.Battery.Model, this.Battery.BatteryType, this.Battery.HoursIdle, this.Battery.HoursTalk);
            result.AppendLine(new string('-', 20));
            result.AppendFormat("Display Information: \n Size: {0}\n Number of colors: {1}",
                                this.Display.Size, this.Display.NumberOfColors);
            return result.ToString();
        }
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public Decimal CallculateCallBill(Decimal pricePerMinute)
        {
            Decimal totalPrice = 0;
            long callSeconds = 0;
            foreach (var call in CallHistory)
            {
                callSeconds += call.Duration;
            }
            totalPrice = (callSeconds / 60) * pricePerMinute; // Divided by 60, because every call has duration in seconds
            return totalPrice;
        }
    }
}
