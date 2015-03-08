using System;
using System.Collections.Generic;
using System.IO;

//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static List<string> ReadEvenLines(StreamReader reader)
        {
            List<string> EvenLines = new List<string>();

            using (reader)
            {
                int lineNumber = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        EvenLines.Add(line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
            return EvenLines;
        }
        static void Main()
        {
            //use Ex9OddLinesCopy for second demo of the same file.
            StreamReader reader = new StreamReader("../../../TextFiles/Results/Ex9OddLines.txt");
            var lines = ReadEvenLines(reader);

            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex9OddLines.txt");
            using (writer)
            {
                foreach (var line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
