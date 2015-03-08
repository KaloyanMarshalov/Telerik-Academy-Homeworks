using System;
using System.IO;

//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

namespace _07.ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/StartFinish.txt");
            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex7.txt");

            using (reader)
            {
                string text = reader.ReadToEnd();
                using (writer)
                {
                    writer.WriteLine(text.Replace("start", "finish"));
                }
            }
        }
    }
}
