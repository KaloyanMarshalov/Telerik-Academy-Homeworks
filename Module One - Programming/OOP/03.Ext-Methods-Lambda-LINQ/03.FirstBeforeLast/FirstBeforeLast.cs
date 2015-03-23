using System;
using System.Linq;

namespace _03.FirstBeforeLast
{
    class FirstBeforeLast
    {
        static void Main()
        {
            var studentArray = new[] {
                new {FirstName = "Pesho", LastName = "Hristov"},
                new {FirstName = "Gosho", LastName = "Jorov"},
                new {FirstName = "Ivan", LastName = "Iordanov"},
                new {FirstName = "Hristo", LastName = "Mihov"},
                new {FirstName = "Joro", LastName = "Lazarov"},
            };

            var result = 
                from student in studentArray
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
