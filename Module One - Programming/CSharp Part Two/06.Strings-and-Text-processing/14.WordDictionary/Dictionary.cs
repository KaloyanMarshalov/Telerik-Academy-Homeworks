using System;
using System.Collections.Generic;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

namespace _14.WordDictionary
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
		    {
			    {".NET", "platform for applications from Microsoft"},
			    {"CLR", "managed execution environment for .NET"},
			    {"NAMESPACE", "hierarchical organization of classes"}
		    };

            Console.Write("Enter a word to see its definition: ");
            string word = Console.ReadLine().ToUpper(); //toUpper, because the dictionary uses uppercase keys

            if (dict.ContainsKey(word))
            {
                Console.WriteLine(dict[word]);
            }
            else
            {
                Console.WriteLine("Could not find the word!");
            }
        }
    }
}
