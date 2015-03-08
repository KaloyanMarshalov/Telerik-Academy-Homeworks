using System;
using System.IO;

//Write a program that extracts from given XML file all the text without the tags.

namespace _10.ExtractTextFromXML
{
    class ExtractFromXML
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/XML.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                string extract = string.Empty;
                while (line != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>')
                        {
                            while (line[i] != '<')
                            {
                                extract += line[i];
                                i++;
                            }
                            if (extract != "")
                            {
                                Console.WriteLine(extract.TrimStart(' '));
                                extract = "";

                                //using (StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex10.txt"))
                                //{
                                //    writer.WriteLine(extract)
                                //}
                            }
                        }
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
