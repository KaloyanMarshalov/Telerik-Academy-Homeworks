using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using 
//some programming logic.
//Print the variable values before and after the exchange.

namespace _9.TwoIntVariables
{
    class IntExchange
    {
        static void Main()
        {
            int firstNum = 5;
            int secondNum = 10;
            int temp = 0;
            Console.WriteLine("First int: {0}, SecondInt: {1}", firstNum, secondNum);

            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("First int: {0}, SecondInt: {1}", firstNum, secondNum);
        }
    }
}
