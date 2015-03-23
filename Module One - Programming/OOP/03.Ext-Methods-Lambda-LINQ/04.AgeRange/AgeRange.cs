using System;
using System.Linq;

namespace _04.AgeRange
{
    class AgeRange
    {
        static void Main(string[] args)
        {
            var studentArray = new[] {
                new {FirstName = "Pesho", LastName = "Hristov", Age = 10},
                new {FirstName = "Gosho", LastName = "Jorov", Age = 18},
                new {FirstName = "Ivan", LastName = "Iordanov", Age = 20},
                new {FirstName = "Hristo", LastName = "Mihov", Age = 24},
                new {FirstName = "Joro", LastName = "Lazarov", Age = 25},
            };

            var result =
                from student in studentArray
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}
