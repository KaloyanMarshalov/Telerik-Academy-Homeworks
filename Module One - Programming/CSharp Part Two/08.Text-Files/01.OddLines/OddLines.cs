using System;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/TextFileOne.txt");

            int currentLine = 0;
            string line = reader.ReadLine();
            using (reader)
            {
                while (line != null)
                {
                    if (currentLine % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    currentLine++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
