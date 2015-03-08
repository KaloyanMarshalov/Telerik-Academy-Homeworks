using System;

//Write a program that safely compares floating-point numbers with precision of 0.000001. 
//Examples:(5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            // There is no need for anything special, because numbers of type float have precision 6 digits
            float firstNum = 2.13f;
            float secondNum = 2.015f;
            Console.WriteLine(firstNum == secondNum);

            float thirdNum = 2.000000000000002f;
            float fourthNum = 2.00000000000001f;
            Console.WriteLine(thirdNum == fourthNum);
        }
    }
}
