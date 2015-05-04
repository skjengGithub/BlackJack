using System;

namespace BlackJack
{
    class BlackJackTest
    {
        public static bool Scenario_1_OK()
        {
            Deck deck = new Deck();
            HumanPlayer player = new HumanPlayer();
            ComputerPlayer computer = new ComputerPlayer();
            player.SaveACard(deck.DealACard());
            computer.SaveACard(deck.DealACard());
            player.SaveACard(deck.DealACard());
            return player.IsBlackJack();
        }

        public static string Scenario_1_Result()
        {
            return (Scenario_1_OK()) ? "passed" : "failed";
        }
    }
}
