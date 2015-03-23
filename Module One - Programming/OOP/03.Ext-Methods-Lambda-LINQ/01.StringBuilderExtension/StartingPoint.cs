using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringBuilderExtension
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            text.Append("Pesho Pesho");
            text = text.Substring(3, 5);
            Console.WriteLine(text);    //ho pe
        }
    }
}
