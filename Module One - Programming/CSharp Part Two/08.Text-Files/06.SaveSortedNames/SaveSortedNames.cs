using System;
using System.IO;
using System.Collections.Generic;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        static List<string> ReadFile(StreamReader reader)
        {
            var result = new List<string>();

            string line = reader.ReadLine();
            using (reader)
            {
                while (line != null)
                {
                    result.Add(line);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/TextFileOne.txt");
            var names = ReadFile(reader);
            names.Sort();

            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex6.txt");
            using (writer)
            {
                foreach (var name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }
    }
}
