using System;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/TextFileOne.txt");
            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex3.txt");

            //int lineNumber = 1;

            int lineNumber = 0;
            string line = reader.ReadLine();    
            
            using (writer)
            {
                while (line != null)
                {
                    writer.Write("{0}. ", lineNumber);
                    writer.WriteLine(line);

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}
