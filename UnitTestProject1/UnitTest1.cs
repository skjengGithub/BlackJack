using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScenario_1()
        {
            Deck deck = new Deck();
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer = new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            Assert.IsTrue(player.IsBlackJack());
        }

        [TestMethod]
        public void TestCard()
        {
            Card c = new Card(Suit.SPADE, 14);
            Assert.IsTrue ((c.suit == Suit.SPADE) && (c.rank == 14));
        }

        [TestMethod]
        public void TestDeck()
        {
            Deck deck = new Deck();
            Card c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.SPADE) && (c.rank == 1));
            c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.HEART) && (c.rank == 11));
            c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.DIAMOND) && (c.rank == 10));
        }

        [TestMethod]
        public void TestCardDeck()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 1),
                new Card(Suit.HEART, 11),
                new Card(Suit.DIAMOND, 10)
                           };
            Deck deck = new Deck(cards);
            Card c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.SPADE) &&
               (c.rank == 1));
            c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.HEART) &&
                (c.rank == 11));
            c = deck.DealACard();
            Assert.IsTrue((c.suit == Suit.DIAMOND) &&
                (c.rank == 10));
        }

        [TestMethod]
        public void TestHumanPlayer()
        {
            HumanPlayer player = new HumanPlayer();
            Deck deck = new Deck();
            player.SaveACard(deck.DealACard());
            Card c = deck.DealACard();
            player.SaveACard(deck.DealACard());
            Assert.IsTrue(player.IsBlackJack());
        }

        [TestMethod]
        public void TestComputerPlayer()
        {
            ComputerPlayer computer = new ComputerPlayer();
            Deck deck = new Deck();
            Card c = deck.DealACard();
            computer.SaveACard(deck.DealACard());
        }

    }
}
