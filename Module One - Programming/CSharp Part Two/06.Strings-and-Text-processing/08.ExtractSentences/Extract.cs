using System;
using System.Collections.Generic;

//Write a program that extracts from a given text all sentences containing given word.

namespace _08.ExtractSentences
{
    class Extract
    {
        static List<string> ExtractSentences(string sentences, string searchedWord)
        {
            var sentecesArray = sentences.Split(new string[] { ". " }, StringSplitOptions.None);
            var containingSenteces = new List<string>();

            foreach (var sentence in sentecesArray)
            {
                string[] words = sentence.Split(new char[] { ',', '-', ':', ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    if (word == searchedWord)
                    {
                        containingSenteces.Add(sentence);
                        break;
                    }
                }
            }

            return containingSenteces;
        }
        static void Main()
        {
            Console.Write("Insert a string: ");
            string input = Console.ReadLine();
            Console.Write("Insert word: ");
            string word = Console.ReadLine();

            //string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //string word = "in";
            var sentences = ExtractSentences(input, word);
            foreach (var sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
