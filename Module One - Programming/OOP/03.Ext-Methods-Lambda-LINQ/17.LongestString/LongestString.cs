using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.LongestString
{
    class LongestString
    {
        static void Main(string[] args)
        {
            var stringArr = new string[] { "Hi", "Hello", "String", "Something", "Add", "So" };
            string longestString = stringArr
                .OrderByDescending(s => s.Length)
                .First();
            Console.WriteLine(longestString);
        }
    }
}
