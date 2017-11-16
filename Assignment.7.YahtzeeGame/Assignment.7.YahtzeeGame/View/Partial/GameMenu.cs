using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment._7.YahtzeeGame.View.CustomControl;
using Assignment._7.YahtzeeGame.Tools;

namespace Assignment._7.YahtzeeGame.View.Partial
{
    public partial class GameMenu : UserControl
    {
        public static Random rng = new Random();

        private List<Bitmap> diceImages;

        public GameMenu()
        {
            InitializeComponent();

            this.bt_Ones.calculateScoreHandler = YahtzeeScoreFunctions.calculateOnes;
            this.bt_Twos.calculateScoreHandler = YahtzeeScoreFunctions.calculateTwos;
            this.bt_Threes.calculateScoreHandler = YahtzeeScoreFunctions.calculateThrees;
            this.bt_Fours.calculateScoreHandler = YahtzeeScoreFunctions.calculateFours;
            this.bt_Fives.calculateScoreHandler = YahtzeeScoreFunctions.calculateFives;
            this.bt_Sixes.calculateScoreHandler = YahtzeeScoreFunctions.calculateSixes;

            this.bt_ThreeOfKind.calculateScoreHandler = YahtzeeScoreFunctions.calculateThreeOfKind;
            this.bt_FourOfKind.calculateScoreHandler = YahtzeeScoreFunctions.calculateFourOfKind;
            this.bt_FullHouse.calculateScoreHandler = YahtzeeScoreFunctions.calculateFullHouse;
            this.bt_SmallStraight.calculateScoreHandler = YahtzeeScoreFunctions.calculateSmallStraight;
            this.bt_LargeStraight.calculateScoreHandler = YahtzeeScoreFunctions.calculateLargeStraight;

            this.bt_Yahtzee.calculateScoreHandler = YahtzeeScoreFunctions.calculateYahtzee;
            this.bt_Chance.calculateScoreHandler = YahtzeeScoreFunctions.calculateChance;

            diceImages = new List<Bitmap>();

            diceImages.Add(Properties.Resources._1);
            diceImages.Add(Properties.Resources._2);
            diceImages.Add(Properties.Resources._3);
            diceImages.Add(Properties.Resources._4);
            diceImages.Add(Properties.Resources._5);
            diceImages.Add(Properties.Resources._6);
        }

        public void toggleYahtzeeButtons(bool shouldBeEnabled)
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is YahtzeeButton)
                    c.Enabled = shouldBeEnabled;
            }
        }

        public void showPotentionalScores(List<int> dices)
        {
            foreach (Control c in this.tableLayoutPanel1.Controls)
            {
                if (c is YahtzeeButton)
                {
                    YahtzeeButton yb = (YahtzeeButton)c;

                    if (!yb.isPicked)
                        yb.calculateScore(dices);
                }
            }
        }

        public void StartGame()
        {
            toggleYahtzeeButtons(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>();

            for (int i = 1; i < 6; i++)
            {
                int c = rng.Next(1, 7);
                a.Add(c);
            }

            this.bt_Dice1.BackgroundImage = diceImages[a[0] - 1];
            this.bt_Dice2.BackgroundImage = diceImages[a[1] - 1];
            this.bt_Dice3.BackgroundImage = diceImages[a[2] - 1];
            this.bt_Dice4.BackgroundImage = diceImages[a[3] - 1];
            this.bt_Dice5.BackgroundImage = diceImages[a[4] - 1];

            a.Sort();
            foreach(int c in a)
            {
                Console.Write(c + " - ");
            }
            Console.WriteLine();

            showPotentionalScores(a);
        }
    }
}
