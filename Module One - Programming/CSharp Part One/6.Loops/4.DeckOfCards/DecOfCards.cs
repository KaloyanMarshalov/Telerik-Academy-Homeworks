using System;

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). \
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

namespace _4.DeckOfCards
{
    class DecOfCards
    {
        static void Main()
        {
            for (int i = 0; i < 13; i++)
            {
                string card = "";
                if (i > 8)
                {
                    switch (i)
                    {
                        case 9: card = "J"; break;
                        case 10: card = "Q"; break;
                        case 11: card = "K"; break;
                        case 12: card = "A"; break;

                    }
                }
                else
                {
                    card = (i + 2).ToString();
                }
                for (int k = 0; k < 4; k++)
                {
                    switch (k)
                    {
                        case 0: Console.Write("{0} of clubs, ", card); break;
                        case 1: Console.Write("{0} of diamonds, ", card); break;
                        case 2: Console.Write("{0} of hearts, ", card); break;
                        case 3: Console.WriteLine("{0} of spades", card); break;
                    }
                }
            }
        }
    }
}
