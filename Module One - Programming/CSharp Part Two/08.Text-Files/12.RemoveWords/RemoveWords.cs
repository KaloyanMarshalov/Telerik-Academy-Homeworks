using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

namespace _12.RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            List<string> result = new List<string>();
            List<string> forbidden = new List<string>();

            try
            {
                StreamReader reader = new StreamReader("../../../TextFiles/ForbiddenWords.txt");
                using (reader)
                {
                    while (!reader.EndOfStream)
                    {
                        string[] words = reader.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                        forbidden.AddRange(words);
                    }
                }
                StreamReader readerTwo = new StreamReader("../../../TextFiles/TextFileOne.txt");
                using (readerTwo)
                {
                    while (!readerTwo.EndOfStream)
                    {
                        string[] words = readerTwo.ReadLine()
                            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(x => !forbidden.Contains(x))
                            .ToArray();

                        result.AddRange(words);
                    }
                }
                StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex12.txt");
                using (writer)
                {
                    writer.Write(String.Join(Environment.NewLine, result));
                }
            }
            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FileLoadException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (EndOfStreamException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}