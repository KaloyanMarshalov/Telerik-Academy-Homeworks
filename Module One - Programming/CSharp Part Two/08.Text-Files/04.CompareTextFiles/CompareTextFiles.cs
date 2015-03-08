using System;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same 
//and the number of lines that are different.
//Assume the files have equal number of lines.

namespace _04.CompareTextFiles
{
    class CompareTextFiles
    {
        static void Main()
        {
            StreamReader readerOne = new StreamReader("../../../TextFiles/TextFileOne.txt");
            StreamReader readerTwo = new StreamReader("../../../TextFiles/SimilarToFileOne.txt");

            int sameLinesCount = 0;
            int differentLinesCount = 0;
            string lineOne = readerOne.ReadLine();
            string lineTwo = readerTwo.ReadLine();
           
            using (readerOne)
            {
                using (readerTwo)
                {
                    while (lineOne != null & lineTwo != null)
                    {
                        if (lineOne == lineTwo)
                        {
                            sameLinesCount++;
                            Console.WriteLine("{0} == {1}", lineOne, lineTwo);
                        }
                        else
                        {
                            differentLinesCount++;
                            Console.WriteLine("{0} != {1}", lineOne, lineTwo);
                        }
                        lineOne = readerOne.ReadLine();
                        lineTwo = readerTwo.ReadLine();
                    }
                }
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Same lines: {0}", sameLinesCount);
            Console.WriteLine("Different lines: {0}", differentLinesCount);
        }
    }
}
