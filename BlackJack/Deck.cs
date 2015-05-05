using System;

namespace BlackJack
{
    public class Deck
    {
        private Card[] cards;
        private int top;
		public Deck()
        {
            cards = new Card[3];
            cards[0] = new Card(Suit.SPADE, 1);
            cards[1] = new Card(Suit.HEART, 11);
            cards[2] = new Card(Suit.DIAMOND, 10);
            top = 0;
        }

        public Deck(Card[] card)
        {
            int nCards = card.Length;
            this.cards = new Card[nCards];
            int i;
            for (i = 0; i < nCards; ++i)
            {
                this.cards[i] = card[i];
            }
        }


        public Card DealACard()
        {
            return cards[top++];
        }
    }
}
