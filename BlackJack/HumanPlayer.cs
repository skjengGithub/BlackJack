using System;

namespace BlackJack
{
    public class HumanPlayer
    {
        private Card[] hand = new Card[2];
        private int nCards = 0;

        public HumanPlayer() {}

        public void SaveACard(Card card)
        {
            hand[nCards++] = card;
        }

		public bool IsBlackJack()
        {
            int point1 = Points( hand[0].rank );
            int point2 = Points( hand[1].rank );
            bool isBlackJack = 
				(point1 + point2 == 21);
            if (!isBlackJack && point1 == 1)
            { 
                point1 = 11;
                isBlackJack = 
				(point1 + point2 == 21);
            }
			if (!isBlackJack && point2 == 1)
            {
                point2 = 11;
                isBlackJack = 
				(point1 + point2 == 21);
            }
            return isBlackJack;
        }

        private int Points(int rank)
        {
            int points = rank;
            if (rank > 10) points = 10;
            return points;
        }
    }
}
