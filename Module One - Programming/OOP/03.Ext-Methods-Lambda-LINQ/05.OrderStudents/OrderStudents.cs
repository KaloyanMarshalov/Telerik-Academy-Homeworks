using System;
using System.Linq;

namespace _05.OrderStudents
{
    class OrderStudents
    {
        static void Main(string[] args)
        {
            var studentArray = new[] {
                new {FirstName = "Pesho", LastName = "Hristov", Age = 10},
                new {FirstName = "Gosho", LastName = "Jorov", Age = 18},
                new {FirstName = "Ivan", LastName = "Iordanov", Age = 20},
                new {FirstName = "Hristo", LastName = "Mihov", Age = 24},
                new {FirstName = "Joro", LastName = "Lazarov", Age = 25},
                new {FirstName = "Joro", LastName = "Ivanov", Age = 25},
                new {FirstName = "Joro", LastName = "Hristov", Age = 25},
            };

            var firstResult = studentArray
                .OrderByDescending(s => s.FirstName)
                .ThenByDescending(s => s.LastName);

            var secondResult =
                from student in studentArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in firstResult)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(new string('=', 20));
            foreach (var student in secondResult)
            {
                Console.WriteLine(student);
            }
        }
    }
}
