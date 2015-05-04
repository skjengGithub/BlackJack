using System;

namespace BlackJack
{
    public class ComputerPlayer
    {
        private Card[] hand = new Card[1];
        private int nCards = 0;
        public ComputerPlayer() { }
        public void SaveACard(Card card)
        {
            hand[nCards++] = card;
        }
    }
}
