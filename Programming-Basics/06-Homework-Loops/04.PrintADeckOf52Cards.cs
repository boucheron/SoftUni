using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        char[] cardSuit = new char[] { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int card = 2; card <= 14; card++)
        {
            for (int suit = 0; suit < 4; suit++)
            {
                switch (card)
                {
                    case 11: Console.Write(" J{0} ", cardSuit[suit]); break;
                    case 12: Console.Write(" Q{0} ", cardSuit[suit]); break;
                    case 13: Console.Write(" K{0} ", cardSuit[suit]); break;
                    case 14: Console.Write(" A{0} ", cardSuit[suit]); break;
                    default: Console.Write("{0,2}{1} ", card, cardSuit[suit]); break;
                }
            }
            Console.WriteLine();
        }

    }
}