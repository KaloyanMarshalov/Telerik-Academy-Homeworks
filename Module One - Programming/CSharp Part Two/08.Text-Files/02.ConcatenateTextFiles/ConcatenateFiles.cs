using System;
using System.IO;

//Write a program that concatenates two text files into another text file.

namespace _02.ConcatenateTextFiles
{
    class ConcatenateFiles
    {
        static void Main()
        {
            StreamReader firstReader = new StreamReader("../../../TextFiles/TextFileOne.txt");
            StreamReader secondReader = new StreamReader("../../../TextFiles/TextFileTwo.txt");

            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex2.txt");

            //concatenating file by file
            string firstText = firstReader.ReadToEnd();
            string secondText = secondReader.ReadToEnd();

            using (writer)
            {
                writer.WriteLine(firstText);
                writer.WriteLine(secondText);
            }

            /*
            //concatenating line by line

            string lineOne = firstReader.ReadLine();
            string lineTwo = secondReader.ReadLine();
            using (writer)
            {
                while (lineOne != null && lineTwo != null)
                {
                    writer.Write(lineOne);
                    writer.Write(lineTwo);
                    writer.WriteLine();
                    lineOne = firstReader.ReadLine();
                    lineTwo = secondReader.ReadLine();
                }
            }
             */
        }
    }
}
