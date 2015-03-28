namespace _02.StudentsAndWorkers
{
    public class Worker : Human
    {
        public Worker(string fname, string lname, int weekSalary, int workHoursDay)
            : base(fname, lname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursDay = workHoursDay;
        }
        public int WeekSalary { get; set; }
        public int WorkHoursDay { get; set; }
        public double MoneyPerHour()
        {
            return WeekSalary / WorkHoursDay * 5;
        }
    }
}
