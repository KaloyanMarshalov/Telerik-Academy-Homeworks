using System;

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

namespace _3.PlayCard
{
    class PlayCard
    {
        static void Main()
        {
            Console.Write("Insert Playing card: ");
            string card = Console.ReadLine();
            int numcard; 

            bool canBeParsed = int.TryParse(card, out numcard);
            if (canBeParsed)
            {
                if (numcard >= 2 && numcard <= 10)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                if (card == "J" || card == "Q" || card == "K" || card == "A")
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
