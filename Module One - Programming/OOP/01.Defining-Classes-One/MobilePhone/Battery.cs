namespace MobilePhone
{
    using System;

    //model, hours idle and hours talk
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private TypeOfBattery batteryType;

        public enum TypeOfBattery
        {
            LiIon, NuMH, NiCd
        }

        public Battery()
        {
        }

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours Idle cannot be less than or equal to zero");
                }
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hours Talk cannot be less than or equal to zero");
                }
                this.hoursTalk = value;
            }
        }
        public TypeOfBattery BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
    }
}
