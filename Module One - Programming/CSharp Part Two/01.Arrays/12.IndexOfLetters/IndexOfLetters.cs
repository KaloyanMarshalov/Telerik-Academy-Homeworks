using System;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            //Create the array of letters
            char[] lettersArray = new char[26];
            for (char i = 'A'; i <= 'Z'; i++)
            {
                lettersArray[i - 65] = i;
            }

            Console.WriteLine("Insert a word in capital letters");
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                int currentIndex = Array.IndexOf(lettersArray, letter);
                Console.WriteLine("{0}: {1}", letter, currentIndex);
            }
        }
    }
}
