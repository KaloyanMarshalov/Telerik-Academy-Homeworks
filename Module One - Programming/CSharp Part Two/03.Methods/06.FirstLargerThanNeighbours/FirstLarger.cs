using System;

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.

namespace _06.FirstLargerThanNeighbours
{
    class FirstLarger
    {
        static bool CheckNeighbours(int[] numArray, int number)
        {
            int numberIndex = Array.IndexOf(numArray, number);

            if (number > numArray[numberIndex - 1] && number > numArray[numberIndex + 1] && numberIndex != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Console.Write("Insert the length of the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] numArray = new int[n];
            Console.WriteLine("Insert the elements of the array");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            //The exercise could be solved with easier solutions, but i have to use the method from the previous
            if (numArray.Length < 3)
            {
                Console.WriteLine("Insufficient length of array");
            }
            else
            {
                int currentIndex = -1;
                for (int i = 1; i < numArray.Length-1; i++)
                {
                    bool isBigger = CheckNeighbours(numArray, numArray[i]);
                    if (isBigger)
                    {
                        currentIndex = i;
                        break;
                    }
                }
                Console.WriteLine(currentIndex);
            }
        }
    }
}
