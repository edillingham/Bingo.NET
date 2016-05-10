using System;
using System.Collections.Generic;
using System.Text;

namespace BingoLib
{
    /// <summary>
    /// Summary description for BingoCardGenerator.
    /// </summary>
    public static class BingoCardGenerator
    {
        private const int NUMBERS_PER_LETTER = 15;

        public static BingoCard Generate(long sessionID)
        {
            BingoCard newCard = new BingoCard(sessionID);
            fillGrid(newCard);
            return newCard;
        }

        public static void Fill(BingoCard card)
        {
            fillGrid(card);
        }

        private static void fillGrid(BingoCard theCard)
        {
            CardPattern p = theCard.GetGrid();

            int letterLo = 1;
            int letterHi = NUMBERS_PER_LETTER;

            List<int> used = new List<int>();
            Random rnd = new Random();
            int num = rnd.Next(letterLo, letterHi);

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (p[c, r] >= 0)
                    {
                        while (used.Contains(num))
                        {
                            num = rnd.Next(letterLo, letterHi);
                        }
                        p[c, r] = num;
                        used.Add(num);
                    }
                    letterLo = letterHi;
                    letterHi += NUMBERS_PER_LETTER;
                }
                letterLo = 1;
                letterHi = NUMBERS_PER_LETTER;
            }

            rnd = null;

            //theCard.Cells = grid;
        }
    }
}
