namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {
        public Student(string fname, string lname, int grade)
            : base(fname, lname)
        {
            this.Grade = grade;
        }
        public int Grade { get; set; }
    }
}
