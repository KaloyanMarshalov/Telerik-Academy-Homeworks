using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            var intList = new GenericList<int>();
            intList.AddElement(5);
            intList.AddElement(3);
            intList.AddElement(1);

            var stringList = new GenericList<string>(10);
            stringList.AddElement("Pesho");
            stringList.AddElement("Gosho");
            stringList.AddElement("Kaloyan");

            intList.InsertElement(12, 2);
            intList.RemoveElement(0);
            Console.WriteLine(intList);
            Console.WriteLine(stringList);
            Console.WriteLine(stringList.Min());
            Console.WriteLine(stringList.Max());
            stringList.Clear();
            Console.WriteLine(intList.Count);
        }
    }
}
