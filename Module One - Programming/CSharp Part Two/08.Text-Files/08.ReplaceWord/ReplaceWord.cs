using System;
using System.IO;

//Modify the solution of the previous problem to replace only whole words (not strings).

namespace _08.ReplaceWord
{
    class ReplaceWord
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/StartFinish.txt");
            StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex8.txt");

            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        int startIndex = line.IndexOf("start");
                        while (startIndex != -1)
                        {
                            if ((startIndex - 1 < 0 || !Char.IsLetter(line[startIndex - 1])) 
                                && (startIndex + 5 >= line.Length) || !Char.IsLetter(line[startIndex + 5]))
                            {
                                line = line.Insert(startIndex, "finish").Remove(startIndex + 6, 5);
                            }
                            startIndex = line.IndexOf("start", startIndex + 1);
                        }
                        writer.WriteLine(line); 
                        line = reader.ReadLine();
                    }

                }
                /* This Solution works only for words, surrounded by whitespaces
                string text = reader.ReadToEnd();
                string[] words = text.Split(' ');

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == "start")
                    {
                        words[i] = "finish";
                    }
                }
                using (writer)
                {
                    writer.WriteLine(string.Join(" ", words));
                }
                 * */
            }
        }
    }
}
