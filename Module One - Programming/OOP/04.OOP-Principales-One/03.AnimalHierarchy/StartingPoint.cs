namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;
    class StartingPoint
    {
        static void Main(string[] args)
        {
            var frogArray = new Frog[] 
            {
                new Frog(12, "Gosho", Gender.Male),
                new Frog(2, "Ivana", Gender.Female),
                new Frog(3, "Petio", Gender.Male),
                new Frog(10, "Kristina", Gender.Female),
                new Frog(60, "Lincho", Gender.Male)
            };
            var kittenArray = new Kitten[]
            {
                new Kitten(10, "Shanon"),
                new Kitten(30, "Susan"),
                new Kitten(2, "Cranberry"),
                new Kitten(15, "Apple"),
                new Kitten(6, "Catname"),
            };

            var frogAge = frogArray.Average(f => f.Age);
            var kittenAge = kittenArray.Average(k => k.Age);
            Console.WriteLine("Frogs' age: {0}", frogAge);
            Console.WriteLine("Kittens' age: {0}", kittenAge);
        }
    }
}
