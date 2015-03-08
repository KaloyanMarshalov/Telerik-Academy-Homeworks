using System;

//Write a program to check if in a given expression the brackets are put correctly.

namespace _03.CorrectBrackets
{
    class BracketsCheck
    {
        static bool CheckBrackets(string expression)
        {
            if (expression[0] == ')')
            {
                return false;
            }

            int counter = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter += 1;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
            }
            if (counter == 0)
            {
                return true;
            }
            return false;   
        }
        static void Main()
        {
            Console.Write("Insert expression: ");
            string expression = Console.ReadLine();

            bool correctBrackets = CheckBrackets(expression);
            Console.WriteLine(correctBrackets);
        }
    }
}
