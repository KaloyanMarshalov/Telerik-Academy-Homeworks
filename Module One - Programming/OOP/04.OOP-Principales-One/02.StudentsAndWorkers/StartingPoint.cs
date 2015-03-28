using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.StudentsAndWorkers
{
    class StartingPoint
    {
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Pesho", "Goshov", 5),
                new Student("Gosho", "Peshov", 3),
                new Student("Ivan", "Stoikov", 6),
                new Student("Stoio", "Ivanov", 2),
                new Student("Hristo", "Georgiev", 2),
                new Student("Georgi", "Ivanov", 3),
                new Student("Plamen", "Konstantinov", 5),
                new Student("Konstantin", "Plamenov", 6),
                new Student("Filip", "Dimitrov", 5),
                new Student("Dimitur", "Filipov", 4)
            };

            var workers = new List<Worker>
            {
                new Worker("Pavel", "Petkov", 20, 3),
                new Worker("Perko", "Pavlov", 120, 3),
                new Worker("Radoslav", "Raspev", 203, 9),
                new Worker("Raspio", "Radoslavov", 11, 1),
                new Worker("Kristian", "Jivkov", 1230, 9),
                new Worker("Jivko", "Kristianov", 170, 10),
                new Worker("Trolei", "Tramvaev", 90, 5),
                new Worker("Tramvai", "Troleev", 10, 6),
                new Worker("Vladislav", "Chervenkov", 2000, 17),
                new Worker("Chervenko", "Vladislavov", 203, 1),
            };

            var sortedStudents = students.OrderBy(st => st.Grade);
            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            List<Human> combinedList = new List<Human>();
            combinedList.AddRange(sortedStudents);
            combinedList.AddRange(sortedWorkers);

            combinedList = combinedList
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();
        }
    }
}
