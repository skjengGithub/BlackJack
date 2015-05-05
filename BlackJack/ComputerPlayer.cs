using System;

namespace BlackJack
{
    public class ComputerPlayer
    {
        private Card[] hand = new Card[3];
        private int nCards;
        private Status status;
        private int totalPoints;

        public ComputerPlayer()
        {
            nCards = 0;
        }

        public void SaveACard(Card card)
        {
            hand[nCards++] = card;
            SetStatus();
        }

        public Status GetStatus()
        {
            return status;
        }

        public int GetTotalPoints()
        {
            return totalPoints;
        }

        private void SetStatus()
        {
            int[] point = new int[nCards];
            int i;
            int sum = 0;
            for (i = 0; i < nCards; ++i)
            {
                point[i] = Points(hand[i].rank);
                sum += point[i];
            }
            status = JudgeStatus(sum);
            totalPoints = sum;
            if (status != Status.PASS) return;

            bool isWithAce = false;

            // check if with Aces
            // needs considering only one Ace
            // to add 10 to it
            // since two Aces would be 22 points
            // and burst
            // if both are treated as 11 points
            for (i = 0; i < nCards; ++i)
            {
                if (point[i] == 1)
                {
                    isWithAce = true;
                    break;
                }
            }

            if (isWithAce)
            {
                sum += 10;
                if (sum == 21)
                {
                    status = Status.BLACK_JACK;
                }
                if (sum <= 21)
                {
                    totalPoints = sum;
                }
                // keep original totalPoints if sum > 21
            }
        }

        private int Points(int rank)
        {
            int points = rank;
            if (rank > 10) points = 10;
            return points;
        }

        private Status JudgeStatus(int sum)
        {
            Status status;
            if (sum == 21)
            {
                status = Status.BLACK_JACK;
            }
            else if (sum > 21)
            {
                status = Status.BURST;
            }
            else
            {
                status = Status.PASS;
            }
            return status;
        }

    }
}
