using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentGroups
{
    class StartingPoint
    {
        static void Main()
        {
            string divisor = new string('=', 50);

            List<Student> studentsList = new List<Student>(){
                new Student("Gosho", "Goshev", 123, "02200300", "gosgos@abv.bg", new List<int>(){1, 2, 3, 3, 6, 6, 2, 3}, 2),
                new Student("Pesho", "Hristov", 1306, "+359878211222", "pepe@gmail.com", new List<int>(){1, 2, 3, 2, 3}, 3),
                new Student("Kolio", "Kokov", 2316, "+359878211222", "koko@abv.bg", new List<int>(){ 6, 2, 3}, 2),
                new Student("Koko", "Kolev", 2306, "03200300", "kkoko@gmail.com", new List<int>(){1, 2, 3, 3, 6, 6, 6, 6, 3}, 2),
                new Student("Hristo", "Pehov", 23, "+239878161222", "hrpe@abv.bg", new List<int>(){3, 3, 3, 3, 3, 3, 3, 5}, 5),
                new Student("Ivan", "Kazumov", 1, "02204509", "ivko@yahoo.com", new List<int>(){1, 5, 5, 6, 2, 2, 3}, 6)
            };
            //task 9
            Console.WriteLine("LINQ groupnum = 2");
            var selectedStudents =
                from student in studentsList
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            foreach (var student in selectedStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 10
            Console.WriteLine("Lambda groupnum = 2");
            var selectedStudentsLambda = studentsList
                .Where(st => st.GroupNumber == 2)
                .OrderBy(st => st.FirstName);
            foreach (var student in selectedStudentsLambda)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 11
            Console.WriteLine("Email = abv.bg");
            var emailStudents =
                from student in studentsList
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (var student in emailStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 12
            Console.WriteLine("Sofia phone");
            var phoneStudents =
                from student in studentsList
                where student.Tel.IndexOf("02") == 0
                select student;
            foreach (var student in phoneStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 13
            Console.WriteLine("Has 6");
            var excellentStudents =
                from student in studentsList
                where student.Marks.Contains(6)
                select new
                {
                    FirstName = student.FirstName,
                    Marks = student.Marks
                };
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 14
            Console.WriteLine("Has two 2s");
            var poorStudents = studentsList
                .Where(st => st.Marks.FindAll(m => m == 2).Count == 2)      //credit to topalkata
                .Select(st => new
                {
                    FirstName = st.FirstName,
                    Marks = st.Marks
                });
            foreach (var student in poorStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 15
            Console.WriteLine("Has FN that ends with 06");
            var yearStudents = studentsList
                .Where(st => st.FN.ToString().EndsWith("06"));
            foreach (var student in yearStudents)
            {
                Console.WriteLine(student.FirstName);
            }
            Console.WriteLine(divisor);
            //task 18
            Console.WriteLine("Group by group number");
            var groupedStudents =
                from student in studentsList
                group student by student.GroupNumber into studentGroup
                select new
                {
                    StudentGroup = studentGroup.Key,
                    studentsInGroup = studentGroup
                };
            foreach (var group in groupedStudents)
            {
                Console.WriteLine(group.StudentGroup);
            }
            Console.WriteLine(divisor);
            //task 19
            Console.WriteLine("Group by group number(extensions)");
            var groupedStudentsLambda = studentsList.GroupBy(st => st.GroupNumber);
            foreach (var group in groupedStudentsLambda)
            {
                Console.WriteLine("Students in group: {0}", group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student.FirstName);
                }
                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
