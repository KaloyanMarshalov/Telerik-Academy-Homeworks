using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BadCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder number = new StringBuilder();
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string order = Console.ReadLine();
                int firstNum = order[0] - '0';
                int secondNum = order[order.Length - 1] - '0';
                char place = order[5];

                if (place == 'b' )
                {
                    numbers.Add(firstNum * 10 + secondNum);
                    
                }
                else if (place == 'a' )
                {
                    numbers.Add(secondNum * 10 + firstNum);
                }
            }
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                number.Append(numbers[i]);
            }

            bool[] numberInformation = new bool[10];

            for (int i = number.Length -1 ; i >= 0; i--)
            {
                int digit = number[i] - '0';
                if (numberInformation[digit] == true)
                {
                    number.Remove(i, 1);
                    continue;
                }
                numberInformation[digit] = true;
            }
            Console.WriteLine(number);
        }
    }
}
