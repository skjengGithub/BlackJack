using System;

namespace BlackJack
{
    public enum Suit
    {
        CLUB = 0,
        DIAMOND = 1,
        HEART = 2,
        SPADE = 3
    }

    public struct Card
    {
        public Suit suit;
        public int rank;

        public Card(Suit suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }
    }
}
