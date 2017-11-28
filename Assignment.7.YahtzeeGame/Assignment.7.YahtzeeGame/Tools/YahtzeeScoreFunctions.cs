using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment._7.YahtzeeGame.Tools
{
    public static class YahtzeeScoreFunctions
    {
        public static int calculateSingle(int number, List<int> dices)
        {
            int score = 0;
            foreach (int i in dices)
            {
                if (i == number)
                    score += number;
            }
            return score;
        }
        public static int calculateOnes(List<int> dices)
        {
            return calculateSingle(1, dices);
        }
        public static int calculateTwos(List<int> dices)
        {
            return calculateSingle(2, dices);
        }
        public static int calculateThrees(List<int> dices)
        {
            return calculateSingle(3, dices);
        }
        public static int calculateFours(List<int> dices)
        {
            return calculateSingle(4, dices);
        }
        public static int calculateFives(List<int> dices)
        {
            return calculateSingle(5, dices);
        }
        public static int calculateSixes(List<int> dices)
        {
            return calculateSingle(6, dices);
        }
        public static int calculateThreeOfKind(List<int> dices)
        {
            int score = 0;
            for (int j = 1; j <= 6; j++)
            {
                int counter = 0;
                foreach (int i in dices)
                {
                    if (i == j)
                        counter++;

                    if (counter == 3)
                        return calculateChance(dices);
                }
            }
            return score;
        }
        public static int calculateChance(List<int> dices)
        {
            return dices.Sum();
        }
        public static int calculateFourOfKind(List<int> dices)
        {
            int score = 0;
            for (int j = 1; j <= 6; j++)
            {
                int counter = 0;
                foreach (int i in dices)
                {
                    if (i == j)
                        counter++;
                    if (counter == 4)
                        return calculateChance(dices);
                }
            }
            return score;
        }
        public static int calculateFullHouse(List<int> dices)
        {
            int score = 0;

            if (dices[0] == dices[1] && dices[3] == dices[4])
            {
                if (dices[1] == dices[2] || dices[3] == dices[2])
                {
                    score = 25;
                }
            }
            return score;
        }
        public static int calculateSmallStraight(List<int> dices)
        {
            List<int> distinctDices = dices.Select(x => x).Distinct().ToList();
            if (distinctDices.Count() > 3)
            {
                if (((distinctDices[0] == 1) && (distinctDices[1] == 2) && (distinctDices[2] == 3) && (distinctDices[3] == 4)) ||
                    ((distinctDices[0] == 2) && (distinctDices[1] == 3) && (distinctDices[2] == 4) && (distinctDices[3] == 5)) ||
                    ((distinctDices[0] == 3) && (distinctDices[1] == 4) && (distinctDices[2] == 5) && (distinctDices[3] == 6)) ||
                    ((distinctDices[0] == 1) && (distinctDices[1] == 2) && (distinctDices[2] == 3) && (distinctDices[3] == 4)) ||
                    ((distinctDices[0] == 2) && (distinctDices[1] == 3) && (distinctDices[2] == 4) && (distinctDices[3] == 5)) ||
                    ((distinctDices[0] == 3) && (distinctDices[1] == 4) && (distinctDices[2] == 5) && (distinctDices[3] == 6)))
                {
                    return 30;
                }
            }
            return 0;
        }

        public static int calculateLargeStraight(List<int> dices)
        {
            List<int> distinctDices = dices.Select(x => x).Distinct().ToList();
            if (distinctDices.Count() > 4)
            {
                if (((distinctDices[0] == 1) && (distinctDices[1] == 2) && (distinctDices[2] == 3) && (distinctDices[3] == 4) && (distinctDices[4] == 5)) ||
                ((distinctDices[0] == 2) && (distinctDices[1] == 3) && (distinctDices[2] == 4) && (distinctDices[3] == 5) && (distinctDices[4] == 6)))
                {
                    return 40;
                }
            }
            return 0;
        }
        public static int calculateYahtzee(List<int> dices)
        {
            if(dices.Select(x => x).Distinct().Count() == 1)
            {
                return 50;
            }
            return 0;
        }

    }
}
