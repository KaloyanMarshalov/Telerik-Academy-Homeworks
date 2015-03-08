using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Write a program that reads a list of words from the file words.txt and finds how many times each of the words is 
//contained in another file test.txt.
//The result should be written in the file result.txt and the words should be sorted by the number 
//of their occurrences in descending order.
//Handle all possible exceptions in your methods.

namespace _13.CountWords
{
    class CountWords
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            StringBuilder result = new StringBuilder();

            try
            {
                StreamReader reader = new StreamReader("../../../TextFiles/WordsList.txt");
                using (reader)
                {
                    GetWordsToCount(wordsCount, reader);
                }

                StreamReader readerTwo = new StreamReader("../../../TextFiles/WordsToCount.txt");
                using (readerTwo)
                {
                    WordsCount(wordsCount, readerTwo);
                }

                foreach (var word in wordsCount)
                {
                    result.AppendLine(String.Format("{0}({1})", word.Key, word.Value));
                }
                StreamWriter writer = new StreamWriter("../../../TextFiles/Results/Ex13.txt");
                using (writer)
                {
                    writer.Write(result);
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
        private static void WordsCount(Dictionary<string, int> wordsCount, StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ', ',', '.', '?', ';', ':', '!', '-' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => wordsCount.ContainsKey(x.ToLower()))
                    .ToArray();

                foreach (var word in words)
                {
                    wordsCount[word] += 1;
                }
            }
        }

        private static void GetWordsToCount(Dictionary<string, int> wordsCount, StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    wordsCount.Add(word, 0);
                }
            }
        }
    }
}
