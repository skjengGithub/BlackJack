using System;

namespace BlackJack
{
    class BlackJackTest
    {
        public static bool Scenario_1_OK()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 1),
                new Card(Suit.HEART, 11),
                new Card(Suit.DIAMOND, 10)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            return (player.GetStatus() ==
                    Status.BLACK_JACK &&
                    computer.GetStatus() ==
                    Status.PASS);

        }

        public static bool Scenario_2_OK()
        {
            Card[] cards = { 
				new Card(Suit.CLUB, 3),
                new Card(Suit.HEART, 11),
                new Card(Suit.SPADE, 10),
                new Card(Suit.DIAMOND, 1)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            return (player.GetStatus() == Status.PASS
                    && computer.GetStatus() ==
                    Status.BLACK_JACK);
        }

        public static bool Scenario_3_OK()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 8),
                new Card(Suit.HEART, 11),
                new Card(Suit.DIAMOND, 7),
                new Card(Suit.SPADE, 2),
                new Card(Suit.CLUB, 6)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            return (player.GetStatus() == Status.BLACK_JACK &&
                    computer.GetStatus() ==
                    Status.PASS);
        }

        public static bool Scenario_4_OK()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 8),
                new Card(Suit.HEART, 5),
                new Card(Suit.DIAMOND, 8),
                new Card(Suit.SPADE, 9),
                new Card(Suit.CLUB, 6)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            return (player.GetStatus() ==
                Status.BURST &&
                    computer.GetStatus() ==
                Status.PASS);
        }

        public static bool Scenario_5_OK()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 8),
                new Card(Suit.HEART, 5),
                new Card(Suit.DIAMOND, 8),
                new Card(Suit.SPADE, 9),
                new Card(Suit.CLUB, 6)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            return (player.GetTotalPoints() == 16 &&
                    computer.GetTotalPoints() == 20);
        }

        public static bool Scenario_6_OK()
        {
            Card[] cards = { 
				new Card(Suit.SPADE, 8),
                new Card(Suit.HEART, 5),
                new Card(Suit.DIAMOND, 8),
                new Card(Suit.SPADE, 9),
                new Card(Suit.CLUB, 8)
                           };
            Deck deck = new Deck(cards);
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer =
                new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            return (player.GetTotalPoints() == 16 &&
                    computer.GetTotalPoints() == 22
                 && computer.GetStatus() ==
                    Status.BURST);
        }

        public static string Scenario_1_Result()
        {
            return (Scenario_1_OK()) ? "passed" : "failed";
        }

        public static string Scenario_2_Result()
        {
            return (Scenario_2_OK()) ? "passed" : "failed";
        }

        public static string Scenario_3_Result()
        {
            return (Scenario_3_OK()) ? "passed" : "failed";
        }

        public static string Scenario_4_Result()
        {
            return (Scenario_4_OK()) ? "passed" : "failed";
        }

        public static string Scenario_5_Result()
        {
            return (Scenario_5_OK()) ? "passed" : "failed";
        }

        public static string Scenario_6_Result()
        {
            return (Scenario_6_OK()) ? "passed" : "failed";
        }
    }
}
