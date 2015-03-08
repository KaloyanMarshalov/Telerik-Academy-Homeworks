using System;
using System.IO;

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

namespace _11.PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../../TextFiles/Test.txt");
            using (reader)
            {
                StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex11.txt");
                using (writer)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] words = line.Split(' ');
                        for (int i = 0; i < words.Length; i++)
                        {
                            // No need to check for TEST or Test, because the exercise only requires searching for "test".
                            if (words[i].IndexOf("test") != 0)
                            {
                                //If the word doesn't start with test, add it to the writer
                                if (i != words.Length - 1)
                                {
                                    writer.Write(words[i] + " ");
                                }
                                else
                                {
                                    writer.Write(words[i]);
                                }
                            }
                        }
                        writer.WriteLine();
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
