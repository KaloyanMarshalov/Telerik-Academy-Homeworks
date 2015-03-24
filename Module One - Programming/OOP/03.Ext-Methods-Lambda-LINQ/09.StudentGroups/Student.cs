namespace _09.StudentGroups
{
    using System.Collections.Generic;
    public class Student
    {
        public Student()
        {
        }
        public Student(string fname, string lname, int FN, string tel, string email, List<int> marks, int groupNum) : this()
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FN = FN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNum;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }
    }
}
